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
    public partial class ReadOnlyRoomForm : Form
    {
        private Room_Controller room_Controller = new Room_Controller();

        public ReadOnlyRoomForm()
        {
            InitializeComponent();
            this.Load += ReadOnlyRoomForm_Load;
        }

        private async void ReadOnlyRoomForm_Load(object sender, EventArgs e)
        {
            var data = await room_Controller.GetAllAsync();
            dgv_room.DataSource = data;

            dgv_room.ReadOnly = true;
            dgv_room.AllowUserToAddRows = false;
            dgv_room.AllowUserToDeleteRows = false;
        }
    }
}
