using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using UnicomTIC_Management_System.Data;
using UnicomTIC_Management_System.Models;
using static System.Collections.Specialized.BitVector32;

namespace UnicomTIC_Management_System.Controller.cs
{
    internal class Course_Controller
    {
       public async Task<List<Course>> GetAllCourseAsync()
       {
            List<Course> course = new List<Course>();

            using (var conn = DBConfig.GetConnection())
            {
                string query = @"SELECT * FROM Course;";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (await reader.ReadAsync())
                        {
                            course.Add(new Course
                            {
                                CourseID = reader.GetInt32(0),
                                CourseName = reader.GetString(1),
                                StartDate = reader.GetDateTime(2),
                                EndDate = reader.GetDateTime(3)
                            });
                        }
                    }
                }
            }
            return course;
       }

        public async Task<DataTable> GetStudentCourseDetailsAsync()
        {
            DataTable dataTable = new DataTable();

            string query = @"
                            SELECT 
                                Student.StudentID,
                                Student.StudentName,
                                Course.CourseName,
                                Course.StartDate,
                                Course.EndDate
                            FROM 
                                Student
                            JOIN 
                                Course
                            ON 
                                Student.CourseID = Course.CourseID;";

            using (var conn = DBConfig.GetConnection())
            {
                await conn.OpenAsync();
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }

            return dataTable;
        }



        public async void AddAsync(Course course)
        {
            using (var conn = DBConfig.GetConnection())
            {
                string query = "INSERT INTO Course (CourseName, StartDate, EndDate) VALUES (@name, @startDate, @endDate);";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", course.CourseName);
                    cmd.Parameters.AddWithValue("@startDate", course.StartDate);
                    cmd.Parameters.AddWithValue("@endDate", course.EndDate);
                    await cmd.ExecuteNonQueryAsync();  
                }
            }
        }

        public async void UpdateAsync(Course course)
        {
            using (var conn = DBConfig.GetConnection())
            {
                string query = "UPDATE Course SET CourseName = @name, StartDate = @startDate, EndDate = @endDate WHERE CourseID = @id;";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", course.CourseName);
                    cmd.Parameters.AddWithValue("@startDate", course.StartDate);
                    cmd.Parameters.AddWithValue("@endDate", course.EndDate);
                    cmd.Parameters.AddWithValue("@id", course.CourseID);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        public async void DeleteAsync(int courseid)
        {
            using (var conn = DBConfig.GetConnection())
            {
                string query = "DELETE FROM Course WHERE CourseID = @id;";

                using (SQLiteCommand cmd = new SQLiteCommand(query,conn))
                {
                    cmd.Parameters.AddWithValue("@id", courseid);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }
                                                          
    }
}
