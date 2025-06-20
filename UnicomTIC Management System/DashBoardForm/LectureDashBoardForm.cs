﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTIC_Management_System.Views;

namespace UnicomTIC_Management_System.DashBoardForm
{
    public partial class LectureDashBoardForm : Form
    {

        public LectureDashBoardForm()
        {
            InitializeComponent();
            LoadForm(new WelcomDashboard());
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

        private void btn_course_Click(object sender, EventArgs e)
        {
            LoadForm(new CourseForm());
        }

        private void btn_timetable_Click(object sender, EventArgs e)
        {
            LoadForm(new TimetableForm()); 
        }

       // private void btn_close_Click(object sender, EventArgs e)
       

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    
}
