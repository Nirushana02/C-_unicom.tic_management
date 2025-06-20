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

        public async Task ResetCourseDataAsync()
        {
            using (var conn = DBConfig.GetConnection())
            {
                //conn.Open();

                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        // Step 1: Delete all rows from the Student table
                        string deleteQuery = "DELETE FROM Course;";
                        using (SQLiteCommand deleteCmd = new SQLiteCommand(deleteQuery, conn))
                        {
                            await deleteCmd.ExecuteNonQueryAsync();
                        }

                        // Step 2: Reset the AUTOINCREMENT ID
                        string resetQuery = "DELETE FROM sqlite_sequence WHERE name = 'Course';";
                        using (SQLiteCommand resetCmd = new SQLiteCommand(resetQuery, conn))
                        {
                            await resetCmd.ExecuteNonQueryAsync();
                        }

                        // Commit transaction
                        transaction.Commit();
                        Console.WriteLine("All course data cleared, and ID reset.");
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        Console.WriteLine($"Error resetting mark data: {ex.Message}");
                    }
                }
            }
        }

    }
}
