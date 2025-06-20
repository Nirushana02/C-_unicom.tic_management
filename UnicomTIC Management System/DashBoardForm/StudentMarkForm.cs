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

namespace UnicomTIC_Management_System.DashBoardForm
{
    public partial class StudentMarkForm : Form
    {
        private readonly int studentID;
        private readonly Mark_Controller mark_Controller = new Mark_Controller();
        public StudentMarkForm(int id)
        {
            InitializeComponent();
            studentID = id;
            this.Load += StudentMarkForm_Load;
        }

        private void StudentMarkForm_Load(object sender, EventArgs e)
        {
            DataTable marksTable = mark_Controller.GetStudentMarksDetailed(studentID);
            dvg_viewmarks.DataSource = marksTable;

            dvg_viewmarks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvg_viewmarks.ReadOnly = true;
            dvg_viewmarks.AllowUserToAddRows = false;
            dvg_viewmarks.AllowUserToDeleteRows = false;
        }
    }
}
