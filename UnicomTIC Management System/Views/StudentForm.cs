using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using UnicomTIC_Management_System.Controller.cs;
using UnicomTIC_Management_System.Models;

namespace UnicomTIC_Management_System
{
    public partial class StudentForm : Form
    {
       
        private Student_Controller student_Controller = new Student_Controller();

        private Course_Controller course_Controller = new Course_Controller();
        private int Clicked_Stu_Id = -1;
        
        public StudentForm()
        {
            InitializeComponent();
            this.Load += StudentForm_Load;
        }

       
        private async void btnadd_Click(object sender, EventArgs e)
        {
            string name = txtBox_name.Text.Trim();
            int courseId =  Convert.ToInt32(cmb_course.SelectedValue); ;

            if (!string.IsNullOrWhiteSpace(name))
            {
                await student_Controller.AddAsync(new Student
                {
                    StudentName = name,
                    CourseID = courseId
                });
                txtBox_name.Clear();
                cmb_course.Text = "";
                await LoadStudents();

                MessageBox.Show("Student Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please fill all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private async void btnupdate_Click(object sender, EventArgs e)

        {
            if (Clicked_Stu_Id != -1)
            {
                await student_Controller.UpdateAsync(new Student
                {
                    StudentID = Clicked_Stu_Id,
                    StudentName = txtBox_name.Text,                  
                    CourseID = Convert.ToInt32(cmb_course.SelectedValue)

                });
                txtBox_name.Clear();                
                Clicked_Stu_Id = -1;
                await LoadStudents();

                MessageBox.Show("Student Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please fill all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private async void btndelete_Click(object sender, EventArgs e)
        {
            if (Clicked_Stu_Id != -1)
            {
                await student_Controller.DeleteAsync(Clicked_Stu_Id);
                txtBox_name.Clear();               
                Clicked_Stu_Id = -1;
                await LoadStudents();

                MessageBox.Show("Student Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please fill all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }

        private void dgv_stu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgv_stu.Rows[e.RowIndex];
                Clicked_Stu_Id = Convert.ToInt32(row.Cells["StudentID"].Value);
                txtBox_name.Text = row.Cells["StudentName"].Value.ToString();
                cmb_course.SelectedValue = row.Cells["CourseID"].Value;
            }
        }
        
        private async void StudentForm_Load(object sender, EventArgs e)
        {
            await LoadStudents();
            await LoadCourses();
            
        }

        private async Task LoadStudents()
        {
            dgv_stu.DataSource = await student_Controller.GetStudentsAsync();
        }

        private async Task LoadCourses()
        {
            var course = await course_Controller.GetAllCourseAsync();
            cmb_course.DataSource = course;
            cmb_course.DisplayMember = "CourseName";
            cmb_course.ValueMember = "CourseID";
        }

        private async void btn_del_all_Click(object sender, EventArgs e)
        {
            var confirmation = MessageBox.Show("Are you sure you want to delete all students and reset IDs?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmation == DialogResult.Yes)
            {
                await student_Controller.ResetStudentDataAsync(); // Resetting IDs
                txtBox_name.Clear();
                Clicked_Stu_Id = -1;
                await LoadStudents();
                MessageBox.Show("All students deleted, and IDs reset.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
