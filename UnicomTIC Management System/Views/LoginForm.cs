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

        private void btn_login_Click(object sender, EventArgs e)
        {
            string[,] credentials = new string[,]
            {
                {"Admin", "admin", "admin123"},
                {"Student", "student", "student123" },
                {"Staff", "staff", "staff123"},
                {"Lecture", "lecture", "lecture123"}
            };
            // Retrieve user input
            string role = comboBox_role.Text;
            string username = txt_name.Text;
            string password = txt_pass.Text;

            // Basic validation
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            // Verify credentials
            bool isValid = false;
            for (int i = 0; i < credentials.GetLength(0); i++)
            {
                if (credentials[i, 0] == role &&
                    credentials[i, 1] == username &&
                     credentials[i, 2] == password)
                {
                    isValid = true;
                    break;
                }
            }

            if (isValid)
            {
                MessageBox.Show($"Login successful as {role}!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();

                if (role.ToLower() == "admin")
                {
                    AdminDashBoardForm adminDashBoardForm = new AdminDashBoardForm();
                    adminDashBoardForm.Show();
                }
                else if (role.ToLower() == "student")
                {
                    StudentDashBoardForm studentDashBoardForm = new StudentDashBoardForm();
                    studentDashBoardForm.Show();
                }
                else if (role.ToLower() == "staff")
                {
                   StaffDashBoardForm staffDashBoardForm = new StaffDashBoardForm();
                   staffDashBoardForm.Show();
                }

                else if (role.ToLower() == "lecture")
                {
                    LectureDashBoardForm lectureDashBoardForm = new LectureDashBoardForm();
                    lectureDashBoardForm.Show();
                }


            }
            else
            {
                MessageBox.Show("Invalid credentials. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
