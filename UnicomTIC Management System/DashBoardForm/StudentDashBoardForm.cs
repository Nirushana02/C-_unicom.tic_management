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
using UnicomTIC_Management_System.Views;

namespace UnicomTIC_Management_System.DashBoardForm
{
    public partial class StudentDashBoardForm : Form
    {
        private readonly int studentID;
        public StudentDashBoardForm(int id)
        {
            InitializeComponent();
            LoadForm(new WelcomDashboard());
            studentID = id;
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

        private void btn_marks_Click(object sender, EventArgs e)
        {
            LoadForm(new StudentMarkForm(studentID));
        }

        private void btn_timetable_Click(object sender, EventArgs e)
        {
            LoadForm(new ReadOnlyTimetableForm());
        }

        private void btn_room_Click(object sender, EventArgs e)
        {
            LoadForm(new ReadOnlyRoomForm());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
