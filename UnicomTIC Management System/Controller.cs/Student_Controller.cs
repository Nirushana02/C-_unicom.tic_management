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
                                StudentID = Convert.ToInt32(reader["StudentID"]),
                                StudentName = reader["StudentName"].ToString(),
                                CourseID = Convert.ToInt32(reader["CourseID"]),
                                
                            });
                        }
                    }
                }
            }
            return student;

        }

        public async Task<Student> GetStudentByNameAsync(string name)
        {
            var all = await GetStudentsAsync();
            return all.FirstOrDefault(s => s.StudentName.Equals(name, System.StringComparison.OrdinalIgnoreCase));
        }

        public async Task AddAsync(Student student)
        {
            using (var conn = DBConfig.GetConnection())
            {
               
                string query = "INSERT INTO Student (StudentName, CourseID) VALUES (@name, @courseId);";

                using (SQLiteCommand cmd = new SQLiteCommand(@query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", student.StudentName);
                    cmd.Parameters.AddWithValue("@courseId", student.CourseID);
                    await cmd.ExecuteNonQueryAsync();
                }

            }
        }
        public async Task UpdateAsync( Student student)
        {
            using (var conn = DBConfig.GetConnection())
            {
                
                string query = "UPDATE Student SET StudentName = @name,CourseID = @courseId  WHERE StudentID = @id;";

                using (SQLiteCommand cmd = new SQLiteCommand(@query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", student.StudentName);
                    cmd.Parameters.AddWithValue("@courseId", student.CourseID);

                    cmd.Parameters.AddWithValue("@id", student.StudentID);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        public async Task DeleteAsync(int studentid)
        {
            using (var conn = DBConfig.GetConnection())
            {
                string query = "DELETE FROM Student WHERE StudentID = @Id";

                using (SQLiteCommand cmd = new SQLiteCommand(@query, conn))
                {

                    cmd.Parameters.AddWithValue("@Id", studentid);
                    await cmd.ExecuteNonQueryAsync();
                }
            }

        }

        public async Task ResetStudentDataAsync()
        {
            using (var conn = DBConfig.GetConnection())
            {
                //conn.Open();

                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        // Step 1: Delete all rows from the Student table
                        string deleteQuery = "DELETE FROM Student;";
                        using (SQLiteCommand deleteCmd = new SQLiteCommand(deleteQuery, conn))
                        {
                            await deleteCmd.ExecuteNonQueryAsync();
                        }

                        // Step 2: Reset the AUTOINCREMENT ID
                        string resetQuery = "DELETE FROM sqlite_sequence WHERE name = 'Student';";
                        using (SQLiteCommand resetCmd = new SQLiteCommand(resetQuery, conn))
                        {
                            await resetCmd.ExecuteNonQueryAsync();
                        }

                        // Commit transaction
                        transaction.Commit();
                        Console.WriteLine("All student data cleared, and ID reset.");
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        Console.WriteLine($"Error resetting student data: {ex.Message}");
                    }
                }
            }
        }

    }
}
