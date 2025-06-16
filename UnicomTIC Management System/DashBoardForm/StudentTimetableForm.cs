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

namespace UnicomTIC_Management_System.DashBoardForm
{
    public partial class StudentTimetableForm : Form
    {
        private readonly string studentUsername;
        private readonly Timetable_Controller timetable_Controller = new Timetable_Controller();

        public StudentTimetableForm(string username)
        {
            InitializeComponent();
            studentUsername = username;
            this.Load += StudentTimetableForm_Load;
        }

        private async void StudentTimetableForm_Load(object sender, EventArgs e)
        {
            /*try
            {
                DataTable timetableTable = await timetable_Controller.GetTimetableAsync(studentUsername);
                // Bind to a DataGridView or any control
                dgv_timetable.DataSource = timetableTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading timetable: " + ex.Message);
            }*/
        }
    }
}
