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
    public partial class SubjectForm : Form
    {
        private Subject_Controller subject_Controller = new Subject_Controller();
        private Course_Controller course_Controller = new Course_Controller();
        private int Clicked_SubjectId = -1;
        public SubjectForm()
        {
            InitializeComponent();
            this.Load += SubjectForm_Load;
        }

        private async void SubjectForm_Load(object sender, EventArgs e)
        {
            await LoadSubjects();
            await LoadCourses();
        }

        private async Task LoadCourses()
        {
            var courses = await course_Controller.GetAllCourseAsync();
            cmb_course.DataSource = courses;
            cmb_course.DisplayMember = "CourseName";
            cmb_course.ValueMember = "CourseID";
        }

        private async Task LoadSubjects()
        {
            dgv_sub.DataSource = await subject_Controller.GetAllSubjectsAsync();
        }

        private async void btn_add_Click(object sender, EventArgs e)
        {
            string name = txt_sub.Text;
            int courseId = Convert.ToInt32(cmb_course.SelectedValue);

            if (!string.IsNullOrWhiteSpace(name))
            {
                await subject_Controller.AddAsync(new Subject 
                {
                    SubjectName = name,
                    CourseID = courseId
                });
                txt_sub.Clear();
                await LoadSubjects();
                {
                    MessageBox.Show("Subject addes Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please enter subject name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void btn_update_Click(object sender, EventArgs e)
        {
            if (Clicked_SubjectId != -1)
            {
                await subject_Controller.UpdateAsync(new Subject
                {
                    SubjectID = Clicked_SubjectId,
                    SubjectName = txt_sub.Text,
                    CourseID = Convert.ToInt32(cmb_course.SelectedValue)
                });
                txt_sub.Clear();
                Clicked_SubjectId = -1;
                await LoadSubjects();

                MessageBox.Show("Subject Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async void btn_delete_Click(object sender, EventArgs e)
        {
            if (Clicked_SubjectId != -1)
            {
                await subject_Controller.DeleteAsync(Clicked_SubjectId);
                txt_sub.Clear();
                Clicked_SubjectId = -1;
                await LoadSubjects();

                MessageBox.Show("Subject Deleted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgv_sub_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgv_sub.Rows[e.RowIndex];
                Clicked_SubjectId = Convert.ToInt32(row.Cells["SubjectID"].Value);
                txt_sub.Text = row.Cells["SubjectName"].Value.ToString();
                cmb_course.SelectedValue = row.Cells["CourseID"].Value;
            }
        }

        private async void btn_del_all_Click(object sender, EventArgs e)
        {                     
            var confirmation = MessageBox.Show("Are you sure you want to delete all subject and reset IDs?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmation == DialogResult.Yes)
            {
                await subject_Controller.ResetSubjectDataAsync(); // Resetting IDs
                txt_sub.Clear();
                Clicked_SubjectId = -1;
                await LoadSubjects();
                MessageBox.Show("All subject deleted, and IDs reset.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
    
}
