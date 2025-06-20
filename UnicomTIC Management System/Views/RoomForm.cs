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

namespace UnicomTIC_Management_System.Views
{
    public partial class RoomForm : Form
    {
        private Room_Controller room_Controller = new Room_Controller();
        private int Clicked_RoomId = -1;
        public RoomForm()
        {
            InitializeComponent();
            this.Load += RoomForm_Load;
        }

        private async void btn_add_Click(object sender, EventArgs e)
        {
            string roomName = txt_rname.Text.Trim();
            string roomType = cmb_type.SelectedItem?.ToString();

            if (!string.IsNullOrWhiteSpace(roomName) && !string.IsNullOrWhiteSpace(roomType))
            {
                await room_Controller.AddAsync(new Room { RoomName = roomName, RoomType = roomType });
                txt_rname.Clear();
                await LoadRoom();
            }
            else
            {
                MessageBox.Show("Please enter room name and select type.");
            }
        }

        private async void btn_update_Click(object sender, EventArgs e)
        {
            if (Clicked_RoomId != -1)
            {
                await room_Controller.UpdateAsync(new Room
                {
                    RoomID = Clicked_RoomId,
                    RoomName = txt_rname.Text.Trim(),
                    RoomType = cmb_type.SelectedItem?.ToString()
                });

                txt_rname.Clear();
                Clicked_RoomId = -1;
                await LoadRoom();
            }
        }

        private async void btn_delete_Click(object sender, EventArgs e)
        {
            if (Clicked_RoomId != -1)
            {
                await room_Controller.DeleteAsync(Clicked_RoomId);
                txt_rname.Clear();
                Clicked_RoomId = -1;
                await LoadRoom();
            }
        }

        private void dgv_room_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgv_room.Rows[e.RowIndex];
                Clicked_RoomId = Convert.ToInt32(row.Cells["RoomID"].Value);
                txt_rname.Text = row.Cells["RoomName"].Value.ToString();
                cmb_type.SelectedItem = row.Cells["RoomType"].Value.ToString();
            }
        }

        private async void RoomForm_Load(object sender, EventArgs e)
        {
            cmb_type.Items.AddRange(new[] { "Lab", "Hall" });
            cmb_type.SelectedIndex = 0;
            await LoadRoom();
        }

        private async Task LoadRoom()
        {
            dgv_room.DataSource = await room_Controller.GetAllAsync();
        }

        private async void btn_del_all_Click(object sender, EventArgs e)
        {
            var confirmation = MessageBox.Show("Are you sure you want to delete all staff and reset IDs?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmation == DialogResult.Yes)
            {
                await room_Controller.ResetRoomDataAsync(); // Resetting IDs
                txt_rname.Clear();
                Clicked_RoomId = -1;
                await LoadRoom();
                MessageBox.Show("All staff deleted, and IDs reset.");
            }
        }
    }


}
