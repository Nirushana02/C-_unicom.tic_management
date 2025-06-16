using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTIC_Management_System.Controller.cs;
using UnicomTIC_Management_System.Models;

namespace UnicomTIC_Management_System.Views
{
    public partial class LectureForm : Form
    {
        private Lecture_Controller lecture_Controller = new Lecture_Controller();
        private int Clicked_LectureId = -1;
        public LectureForm()
        {
            InitializeComponent();
            this.Load += LectureForm_Load;
        }

        private async void btn_lec_add_Click(object sender, EventArgs e)
        {   
            string lectureName = txt_lec_name.Text.Trim();
            string address = txt_lec_add.Text.Trim();

            if (!string.IsNullOrWhiteSpace(lectureName) && !string.IsNullOrWhiteSpace(address))
            {
                await lecture_Controller.AddAsync(new Lecture 
                {
                    LectureName = lectureName,
                    Address = address
                });
                txt_lec_name.Clear();
                txt_lec_add.Clear();
                await LoadLectures();
            }
            else
            {
                MessageBox.Show("Please enter lecture name and address.");
            }

        }

        private async void btn_lec_update_Click(object sender, EventArgs e)
        {
            if (Clicked_LectureId != -1)
            {
                string lectureName = txt_lec_name.Text.Trim().ToUpper();
                string address = txt_lec_add.Text.Trim();

                if (!string.IsNullOrWhiteSpace(lectureName) && !string.IsNullOrWhiteSpace(address))
                {
                    await lecture_Controller.UpdateAsync(new Lecture
                    {
                        LectureID = Clicked_LectureId,
                        LectureName = txt_lec_name.Text.Trim(),
                        Address = txt_lec_add.Text
                    });

                    MessageBox.Show("Lecture updated successfully!");

                    txt_lec_name.Clear();
                    Clicked_LectureId = -1;
                    await LoadLectures();
                }

                else
                {
                    MessageBox.Show("Please enter both lecture name and address.");
                }
            }
        }

        private async void btn_lec_delete_Click(object sender, EventArgs e)
        {
            if (Clicked_LectureId != -1)
            {
                var confirmResult = MessageBox.Show(
                    "Are you sure you want to delete this lecture?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirmResult == DialogResult.Yes)
                {
                    await lecture_Controller.DeleteAsync(Clicked_LectureId);

                    MessageBox.Show("Lecture deleted successfully!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txt_lec_name.Clear();
                    txt_lec_add.Clear();
                    Clicked_LectureId = -1;

                    await LoadLectures();
                }
            }
            else
            {
                MessageBox.Show("No lecture selected for deletion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        /*private void dgv_lecture_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgv_lecture.Rows[e.RowIndex];
                Clicked_LectureId = Convert.ToInt32(row.Cells["LectureId"].Value);
                txt_lec_name.Text = row.Cells["LectureName"].Value.ToString();
                txt_lec_add.Text = row.Cells["Address"].Value.ToString();
            }
        }*/

        private async Task LoadLectures()
        {
            dgv_lecture.DataSource = await lecture_Controller.GetLecturesAsync();
        }

        private void dgv_lecture_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgv_lecture.Rows[e.RowIndex];
                Clicked_LectureId = Convert.ToInt32(row.Cells["LectureID"].Value);
                txt_lec_name.Text = row.Cells["LectureName"].Value.ToString();
                txt_lec_add.Text = row.Cells["Address"].Value.ToString();
            }
        }

        private async void LectureForm_Load(object sender, EventArgs e)
        {
            await LoadLectures();
        }
    }
}
