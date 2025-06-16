using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTIC_Management_System.Data;
using UnicomTIC_Management_System.Models;

namespace UnicomTIC_Management_System.Controller.cs
{
    internal class Student_Controller
    {
        public async Task<List<Student>> GetStudentsAsync()
        {
            List<Student> student = new List<Student>();

            using (var conn = DBConfig.GetConnection())
            {
                string query = @"SELECT * FROM Student;";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (await reader.ReadAsync())
                        {
                            student.Add(new Student
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                Name = reader["Name"].ToString(),
                                CourseId = Convert.ToInt32(reader["CourseId"]),
                            });
                        }
                    }
                }
            }
            return student;

        }

        public async Task AddAsync(Student student)
        {
            using (var conn = DBConfig.GetConnection())
            {
                await conn.OpenAsync();

                string query = "INSERT INTO Student (Name, CourseId) VALUES (@name, @courseId);";

                using (SQLiteCommand cmd = new SQLiteCommand(@query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", student.Name);
                    cmd.Parameters.AddWithValue("@courseId", student.CourseId);
                    await cmd.ExecuteNonQueryAsync();
                }

            }
        }
        public async Task UpdateAsync( Student student)
        {
            using (var conn = DBConfig.GetConnection())
            {
                await conn.OpenAsync();

                string query = "UPDATE Student SET Name = @name,CourseId = @courseId WHERE Id = @id;";

                using (SQLiteCommand cmd = new SQLiteCommand(@query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", student.Name);
                    cmd.Parameters.AddWithValue("@courseId", student.CourseId);
                    cmd.Parameters.AddWithValue("@id", student.Id);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        public async Task DeleteAsync(int id)
        {
            using (var conn = DBConfig.GetConnection())
            {
                await conn.OpenAsync();

                string query = "DELETE FROM Student WHERE Id = @Id";

                using (SQLiteCommand cmd = new SQLiteCommand(@query, conn))
                {

                    cmd.Parameters.AddWithValue("@Id", id);
                    await cmd.ExecuteNonQueryAsync();
                }
            }

        }

    }
}
