using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTIC_Management_System.Models;

namespace UnicomTIC_Management_System.Views
{
    public partial class AdminDashBoardForm : Form
    {
        public AdminDashBoardForm()
        {
            InitializeComponent();
            LoadForm(new DashboardForm());
        }

        public void LoadForm(object formObj)
        {
            if (formObj is Form form)
            {
                if (this.mainPanel.Controls.Count > 0)
                {
                    this.mainPanel.Controls.RemoveAt(0);
                }

                //Form form = formObj as Form;
                form.TopLevel = false;
                form.Dock = DockStyle.Fill;
                this.mainPanel.Controls.Add(form);
                this.mainPanel.Tag = form;
                form.Show();
            }
        }

        private void btn_mang_stu_Click(object sender, EventArgs e)
        {

            LoadForm(new StudentForm());
        }

        private void btn_mang_lec_Click(object sender, EventArgs e)
        {

            LoadForm(new LectureForm());
        }

        private void btn_mang_cou_Click(object sender, EventArgs e)
        {

            LoadForm(new CourseForm());
        }

        private void btn_mang_timetable_Click(object sender, EventArgs e)
        {

            LoadForm(new TimetableForm());
        }

        private void btn_manag_exam_Click(object sender, EventArgs e)
        {

            LoadForm(new ExamForm());
        }

        private void btn_manag_mark_Click(object sender, EventArgs e)
        {

            LoadForm(new MarkForm());
        }

        private void btn_manag_room_Click(object sender, EventArgs e)
        {

            LoadForm(new RoomForm());
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_manag_sub_Click(object sender, EventArgs e)
        {
            LoadForm(new SubjectForm());
        }

        private void btn_manag_staff_Click(object sender, EventArgs e)
        {
            LoadForm(new StaffForm());
        }
    }
}
