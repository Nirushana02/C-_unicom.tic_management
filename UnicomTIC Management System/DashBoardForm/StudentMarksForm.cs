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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace UnicomTIC_Management_System.DashBoardForm
{
    public partial class StudentMarksForm : Form
    {
        private readonly string studentUsername;
        private readonly Mark_Controller mark_Controller = new Mark_Controller();

        public StudentMarksForm(string Username)
        {
            InitializeComponent();
            studentUsername = Username;
            this.Load += StudentMarksForm_Load;
        }

        private async void StudentMarksForm_Load(object sender, EventArgs e)
        {
            /*try
            {
                DataTable marksTable = await mark_Controller.GetAllMarksByStudentAsync(studentUsername);

                dgv_stu_mark.DataSource = marksTable;

                dgv_stu_mark.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgv_stu_mark.ReadOnly = true;

                dgv_stu_mark.AllowUserToAddRows = false;

                dgv_stu_mark.AllowUserToDeleteRows = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading marks: " + ex.Message);
            }*/
        }
    }
}
