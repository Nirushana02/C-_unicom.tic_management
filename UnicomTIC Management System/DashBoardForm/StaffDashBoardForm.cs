using System;
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
    public partial class StaffDashBoardForm : Form
    {
        public StaffDashBoardForm()
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

    }
}
