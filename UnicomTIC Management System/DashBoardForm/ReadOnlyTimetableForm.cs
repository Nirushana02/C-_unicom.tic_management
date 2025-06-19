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

namespace UnicomTIC_Management_System.Views
{
    public partial class ReadOnlyTimetableForm : Form
    {
        private Timetable_Controller timetable_Controller = new Timetable_Controller();
        public ReadOnlyTimetableForm()
        {
            InitializeComponent();
            this.Load += ReadOnlyTimetableForm_Load;
        }

        private async void  ReadOnlyTimetableForm_Load(object sender, EventArgs e)
        {
            var data = await timetable_Controller.show_TimetableAsync();
            dgv_timetable.DataSource = data;

            dgv_timetable.ReadOnly = true;
            dgv_timetable.AllowUserToAddRows = false;
            dgv_timetable.AllowUserToDeleteRows = false;
        }
    }
}
