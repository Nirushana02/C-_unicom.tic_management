using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTIC_Management_System.Controller.cs;
using UnicomTIC_Management_System.Models;

namespace UnicomTIC_Management_System.Views
{
    public partial class StaffForm : Form
    {
        private Staff_Controller staff_Controller = new Staff_Controller();
        private int Clicked_ID = -1;
        public StaffForm()
        {
            InitializeComponent();
            this.Load += StaffForm_Load; 
        }

        private async void StaffForm_Load(object sender, EventArgs e)
        {
            await LoadStaffs();
        }

        private async Task LoadStaffs()
        {
            dgv_staff.DataSource = await staff_Controller.GetAllStaffAsync();
        }

        private async void btn_add_Click(object sender, EventArgs e)
        {
            string name = txt_name.Text;
            string number = txt_number.Text;
            string gender = cmb_gender.SelectedItem?.ToString();
            string status = cmb_status.SelectedItem?.ToString();

            if (!string.IsNullOrWhiteSpace(name) || !string.IsNullOrWhiteSpace(gender))
            {
                staff_Controller.AddAsync(new Staff
                {
                    StaffName = name,
                    PhoneNumber = number,
                    Gender = gender,
                    Status = status
                });
                txt_name.Clear();
                txt_number.Clear();
                await LoadStaffs();
            }
        }
        

        private async void btn_update_Click(object sender, EventArgs e)
        {
            if (Clicked_ID != -1)
            {
                // Validate input
                if (string.IsNullOrWhiteSpace(txt_name.Text))
                {
                    MessageBox.Show("Please enter a name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txt_number.Text.Trim(), out int phoneNumber))
                {
                    MessageBox.Show("Please enter a valid numeric phone number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (txt_number.Text.Trim().Length != 10)
                {
                    MessageBox.Show("Phone number must be exactly 10 digits.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cmb_gender.SelectedItem == null || cmb_status.SelectedItem == null)
                {
                    MessageBox.Show("Please select a gender and status.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    // Perform update
                    staff_Controller.UpdateAsync(new Staff
                    {
                        StaffID = Clicked_ID,
                        StaffName = txt_name.Text.Trim(),
                        PhoneNumber = txt_number.Text.Trim(),
                        Gender = cmb_gender.SelectedItem.ToString(),
                        Status = cmb_status.SelectedItem.ToString()
                    });

                    // Clear fields
                    txt_name.Clear();
                    txt_number.Clear();
                    cmb_gender.SelectedIndex = -1;
                    cmb_status.SelectedIndex = -1;
                    Clicked_ID = -1;

                    // Reload data
                    await LoadStaffs();
                    MessageBox.Show("Staff record updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while updating the staff record: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a staff record to update.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async void btn_delete_Click(object sender, EventArgs e)
        {
            if (Clicked_ID != -1)
            {
                staff_Controller.DeleteAsync(Clicked_ID);
                txt_name.Clear();
                Clicked_ID = -1;
                await LoadStaffs();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_staff.Rows[e.RowIndex];
                Clicked_ID = Convert.ToInt32(row.Cells["StaffID"].Value);
                txt_name.Text = row.Cells["StaffName"].Value.ToString();
            }
        }

        private async void btn_del_all_Click(object sender, EventArgs e)
        {
            var confirmation = MessageBox.Show("Are you sure you want to delete all staff and reset IDs?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmation == DialogResult.Yes)
            {
                await staff_Controller.ResetStaffDataAsync(); // Resetting IDs
                txt_name.Clear();
                Clicked_ID = -1;
                await LoadStaffs();
                MessageBox.Show("All staff deleted, and IDs reset.");
            }
        }
    }
}
