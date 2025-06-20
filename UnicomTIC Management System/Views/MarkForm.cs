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
    public partial class MarkForm : Form
    {
        private Mark_Controller mark_Controller = new Mark_Controller();
        private Student_Controller student_Controller = new Student_Controller();
        private Exam_Controller exam_Controller = new Exam_Controller();
        private int Clicked_MarkId = -1;
        public MarkForm()
        {
            InitializeComponent();
            this.Load += MarkForm_Load;
            this.dgv_marks.CellContentClick += dgv_marks_CellContentClick;
        }

        private async void MarkForm_Load(object sender, EventArgs e)
        {
            await LoadExams();
            //await LoadStudents();
            await LoadMarks();
        }
       

        

        private async Task LoadExams()
        {
            var exam = await exam_Controller.GetAllExamAsync();
            cmd_exam.DataSource = exam;
            cmd_exam.DisplayMember = "ExamName";
            cmd_exam.ValueMember = "ExamID";
        }

        private async Task LoadMarks()
        {
            dgv_marks.DataSource = await mark_Controller.GetAllMarksAsync();
        }

        private async void btn_add_Click(object sender, EventArgs e)
        {
            int studentId = Convert.ToInt32(txt_name.Tag);
            int examId = Convert.ToInt32(cmd_exam.SelectedValue);
            int score = Convert.ToInt32(txt_score.Text);

            await mark_Controller.AddAsync(new Mark
            {
                StudentID = studentId,
                ExamID = examId,
                Score = score
            });
            txt_name.Clear();
            txt_score.Clear();
            await LoadMarks();

            MessageBox.Show("Marks Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private async void btn_update_Click(object sender, EventArgs e)
        {
            if (Clicked_MarkId != -1)
            {
                await mark_Controller.UpdateAsync(new Mark
                {
                    MarkID = Clicked_MarkId,
                    StudentID = Convert.ToInt32(txt_name.Tag),
                    ExamID = Convert.ToInt32(cmd_exam.SelectedValue),
                    Score = Convert.ToInt32(txt_score.Text)
                });

                txt_name.Clear();
                txt_score.Clear();
                Clicked_MarkId = -1;
                await LoadMarks();

                MessageBox.Show("Marks Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async void btn_delete_Click(object sender, EventArgs e)
        {
            if (Clicked_MarkId != -1)
            {
               await mark_Controller.DeleteAsync(Clicked_MarkId);
                txt_name.Clear();
                txt_score.Clear();
                Clicked_MarkId = -1;
                await LoadMarks();

                MessageBox.Show("Marks Deleted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            ;
        }

        private void dgv_marks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgv_marks.Rows[e.RowIndex];
                Clicked_MarkId = Convert.ToInt32(row.Cells["MarkID"].Value);
                int studentId = Convert.ToInt32(row.Cells["StudentID"].Value);
                //cmd_student.SelectedValue = row.Cells["StudentID"].Value;
                cmd_exam.SelectedValue = row.Cells["ExamID"].Value;
                txt_score.Text = row.Cells["Score"].Value.ToString();
            }
        }

        private async void btn_del_all_Click(object sender, EventArgs e)
        {
            var confirmation = MessageBox.Show("Are you sure you want to delete all marks and reset IDs?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmation == DialogResult.Yes)
            {
                await mark_Controller.ResetMarkDataAsync(); // Resetting IDs
                txt_name.Clear();
                txt_score.Clear();
                Clicked_MarkId = -1;
                await LoadMarks();
                MessageBox.Show("All marks deleted, and IDs reset.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
