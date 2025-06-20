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
using static System.Collections.Specialized.BitVector32;

namespace UnicomTIC_Management_System.Views
{
    public partial class CourseForm : Form
    {
        private  Course_Controller course_Controller = new Course_Controller();
        private int Clicked_Id = -1;

        public CourseForm()
        {
            InitializeComponent();
            this.Load += CourseForm_Load;
        }
        private async void CourseForm_Load(object sender, EventArgs e)
        {
            await LoadCourses();
        }

        private async Task LoadCourses()
        {
            dgv_course.DataSource = await course_Controller.GetAllCourseAsync();
        }


        private async void btn_c_add_Click(object sender, EventArgs e)
        {
            string name = txt_cname.Text;
            DateTime startDate =  dtp_start.Value;
            DateTime endDate = dtp_end.Value;


            if (!string.IsNullOrWhiteSpace(name))
            {
                 course_Controller.AddAsync(new Course
                {
                    CourseName = name,
                    StartDate = startDate,
                    EndDate = endDate,
                });
                txt_cname.Clear();
                await LoadCourses();

                MessageBox.Show("Course addes Successfylly", " Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Please enter all fields", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void btn_c_update_Click(object sender, EventArgs e)
        {
            if (Clicked_Id != -1)
            {
                 course_Controller.UpdateAsync(new Course
                {
                    CourseID = Clicked_Id,
                    CourseName = txt_cname.Text.Trim()
                });
                txt_cname.Clear();
                Clicked_Id = -1;
                await LoadCourses();

                MessageBox.Show("Course updated Successfully!");
            }
            else
            {
                MessageBox.Show("Upadate Fail");
            }
        }

        private async void btn_c_delete_Click(object sender, EventArgs e)
        {
            if (Clicked_Id != -1)
            {
                course_Controller.DeleteAsync(Clicked_Id);
                txt_cname.Clear();
                Clicked_Id = -1;
                await LoadCourses();

                MessageBox.Show("Course Deleted Sucessfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Error in Delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgv_course_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_course.Rows[e.RowIndex];
                Clicked_Id = Convert.ToInt32(row.Cells["CourseID"].Value);
                txt_cname.Text = row.Cells["CourseName"].Value.ToString();
            }
        }

        private async void btn_del_all_Click(object sender, EventArgs e)
        {
            var confirmation = MessageBox.Show("Are you sure you want to delete all courses and reset IDs?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmation == DialogResult.Yes)
            {
                await course_Controller.ResetCourseDataAsync(); // Resetting IDs
                txt_cname.Clear();
                Clicked_Id = -1;
                await LoadCourses();
                MessageBox.Show("All courses deleted, and IDs reset.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
