﻿using System;
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
    public partial class ExamForm : Form
    {
        private  Exam_Controller exam_Controller = new Exam_Controller();
        private  Subject_Controller subject_Controller = new Subject_Controller();
        private int Clicked_ExamId = -1;
        public ExamForm()
        {
            InitializeComponent();
            this.Load += ExamForm_Load;
        }

        private async void ExamForm_Load(object sender, EventArgs e)
        {
            await LoadExams();
            await LoadSubjects();
        }
        private async Task LoadSubjects()
        {
            var subjects =  await subject_Controller.GetAllSubjectsAsync();
            cmb_sub.DataSource = subjects;
            cmb_sub.DisplayMember = "SubjectName";
            cmb_sub.ValueMember = "SubjectID";
        }

        private async Task LoadExams()
        {
            dgv_exam.DataSource = await exam_Controller.GetAllExamAsync();
        }

        private async void btn_add_Click(object sender, EventArgs e)
        {
            string examName = txt_exam.Text.Trim();
            int subjectId = Convert.ToInt32 (cmb_sub.SelectedValue);

            if (!string.IsNullOrWhiteSpace(examName))
            {
                await exam_Controller.AddAsync(new Exam
                {
                    ExamName = examName,
                    SubjectID = subjectId
                });
                txt_exam.Clear();
                await LoadExams();

                MessageBox.Show("Exam added Successfully!", "Success ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Please enter exam name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private async void btn_update_Click(object sender, EventArgs e)
        {
            if (Clicked_ExamId != -1)
            {
                await exam_Controller.UpdateAsync(new Exam
                {
                    ExamID = Clicked_ExamId,
                    ExamName = txt_exam.Text.Trim(),
                    SubjectID = Convert.ToInt32(cmb_sub.SelectedValue)
                });

                txt_exam.Clear();
                Clicked_ExamId = -1;
                await LoadExams();

                MessageBox.Show("Exam name updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Please select the exam name to update!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void btn_delete_Click(object sender, EventArgs e)
        {
            if (Clicked_ExamId != -1)
            {
                await exam_Controller.DeleteAsync(Clicked_ExamId);
                txt_exam.Clear();
                Clicked_ExamId = -1;
                await LoadExams();

                MessageBox.Show("Exam details deleted Successfully!", "Successr", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Please select the exam name to Delete", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgv_exam_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgv_exam.Rows[e.RowIndex];
                Clicked_ExamId = Convert.ToInt32(row.Cells["ExamID"].Value);
                txt_exam.Text = row.Cells["ExamName"].Value.ToString();
                cmb_sub.SelectedValue = row.Cells["SubjectID"].Value;
            }
        }

        private async void btn_del_all_Click(object sender, EventArgs e)
        {
            var confirmation = MessageBox.Show("Are you sure you want to delete all exams and reset IDs?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmation == DialogResult.Yes)
            {
                await exam_Controller.ResetExamDataAsync(); // Resetting IDs
                txt_exam.Clear();
                Clicked_ExamId = -1;
                await LoadExams();
                MessageBox.Show("All exams deleted, and IDs reset.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
