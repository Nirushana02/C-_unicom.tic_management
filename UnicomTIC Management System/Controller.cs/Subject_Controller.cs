using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using UnicomTIC_Management_System.Data;
using UnicomTIC_Management_System.Models;

namespace UnicomTIC_Management_System.Controller.cs
{
    internal class Subject_Controller
    {
        public async Task<List<Subject>> GetAllSubjectsAsync()
        {
            List<Subject> subject = new List<Subject>();

            using (var conn = DBConfig.GetConnection())
            {
                string query = @"SELECT * FROM Subject;";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (await reader.ReadAsync())
                        {
                            subject.Add(new Subject
                            {
                                SubjectID = reader.GetInt32(0),
                                SubjectName = reader.GetString(1),
                                CourseID= reader.GetInt32(2)

                            });
                        }
                    }
                }
            }
            return subject;
        }

        public async Task AddAsync(Subject subject)
        {
            using (var conn = DBConfig.GetConnection())
            {
                string query = "INSERT INTO Subject (SubjectName, CourseID) VALUES (@name, @courseId)";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {

                    cmd.Parameters.AddWithValue("@name", subject.SubjectName);
                    cmd.Parameters.AddWithValue("@courseId", subject.CourseID);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        public async Task UpdateAsync(Subject subject)
        {
            using (var conn = DBConfig.GetConnection())
            {
                string query = "UPDATE Subject SET SubjectName = @name, CourseID = @courseId WHERE SubjectID = @id";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", subject.SubjectName);
                    cmd.Parameters.AddWithValue("@courseId", subject.CourseID);
                    cmd.Parameters.AddWithValue("@id", subject.SubjectID);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        public async Task DeleteAsync(int subjectid)
        {
            using (var conn = DBConfig.GetConnection())
            {
                string query = "DELETE FROM Subject WHERE SubjectID = @id;";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", subjectid);
                    await cmd.ExecuteNonQueryAsync();

                }
            }
        }

        public  async Task ResetSubjectDataAsync()
        {
            using (var conn = DBConfig.GetConnection())
            {
                //conn.Open();

                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        // Step 1: Delete all rows from the Student table
                        string deleteQuery = "DELETE FROM Subject;";
                        using (SQLiteCommand deleteCmd = new SQLiteCommand(deleteQuery, conn))
                        {
                            await deleteCmd.ExecuteNonQueryAsync();
                        }

                        // Step 2: Reset the AUTOINCREMENT ID
                        string resetQuery = "DELETE FROM sqlite_sequence WHERE name = 'Subject';";
                        using (SQLiteCommand resetCmd = new SQLiteCommand(resetQuery, conn))
                        {
                            await resetCmd.ExecuteNonQueryAsync();
                        }

                        // Commit transaction
                        transaction.Commit();
                        Console.WriteLine("All subject data cleared, and ID reset.");
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        Console.WriteLine($"Error resetting subject data: {ex.Message}");
                    }
                }
            }
        }
    }
}