using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTIC_Management_System.Controller.cs;
using UnicomTIC_Management_System.DashBoardForm;

namespace UnicomTIC_Management_System.Views
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            comboBox_role.Items.Add("Admin");
            comboBox_role.Items.Add("Student");
            comboBox_role.Items.Add("Lecture");
            comboBox_role.Items.Add("Staff");
            comboBox_role.SelectedIndex = 0;
        }

        private void chebox_pass_CheckedChanged(object sender, EventArgs e)
        {
            txt_pass.PasswordChar = chebox_pass.Checked ? '\0' : '*';       
        }

        private async void btn_login_Click(object sender, EventArgs e)
        {

            string username = txt_name.Text.Trim();
            string password = txt_pass.Text.Trim();
            string selectedRole = comboBox_role.SelectedItem.ToString();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var login_Controller = new Login_Controller();

            if (selectedRole == "Student")
            {
                var user = await login_Controller.ValidateStudentAsync(username, password);
                if (user != null)
                {
                    MessageBox.Show("Login successful as Student", "Success");
                    this.Hide();
                    new StudentDashBoardForm(user.UserID).Show();
                }
                else
                {
                    MessageBox.Show("Invalid Student name or ID", "Login Failed");
                }
            }
            else
            {

                if ((selectedRole == "Admin" && username == "admin" && password == "admin123") ||
                    (selectedRole == "Staff" && username == "staff" && password == "staff123") ||
                    (selectedRole == "Lecturer" && username == "lecturer" && password == "lecturer123"))
                {
                    this.Hide();

                    if (selectedRole == "Admin")
                        new AdminDashBoardForm().ShowDialog();
                    else if (selectedRole == "Staff")
                        new StaffDashBoardForm().ShowDialog();
                    else if (selectedRole == "Lecturer")
                        new LectureDashBoardForm().ShowDialog();
                }
                else
                {
                    MessageBox.Show("Invalid username or password", "Login Failed");
                }
            }

        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
