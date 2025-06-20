using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTIC_Management_System.Data;
using UnicomTIC_Management_System.Models;

namespace UnicomTIC_Management_System.Controller.cs
{
    internal class Exam_Controller
    {
        public async Task<List<Exam>> GetAllExamAsync()
        {
            List<Exam> exam = new List<Exam>();

            using (var conn = DBConfig.GetConnection())
            {
                string query = @"SELECT * FROM Exam;";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (await reader.ReadAsync())
                        {
                            exam.Add(new Exam
                            {
                                ExamID = reader.GetInt32(0),
                                ExamName = reader.GetString(1),
                                SubjectID = reader.GetInt32(2)
                                
                            });
                        }
                    }
                }
            }
            return exam;
        }

        public async Task AddAsync(Exam exam)
        { 
            using (var conn = DBConfig.GetConnection())
            {
                string query = "INSERT INTO Exam (ExamName, SubjectID) VALUES (@name, @subjectId);";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", exam.ExamName);
                    cmd.Parameters.AddWithValue("@subjectId", exam.SubjectID);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        public async Task UpdateAsync(Exam exam)
        {
            using (var conn = DBConfig.GetConnection())
            {
                string query = "Update Exam SET (ExamName = @name, SubjectID = @sbjectId WHERE ExamId = @id;";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", exam.ExamName);
                    cmd.Parameters.AddWithValue("@subjectId", exam.SubjectID);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        public async Task DeleteAsync(int examid)
        {
            using (var conn = DBConfig.GetConnection())
            {
                string query = "DELETE FROM Exam WHERE ExamID = @id;";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", examid);
                    await cmd.ExecuteNonQueryAsync();

                }
            }
        }

        public async Task ResetExamDataAsync()
        {
            using (var conn = DBConfig.GetConnection())
            {
                //conn.Open();

                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        // Step 1: Delete all rows from the Student table
                        string deleteQuery = "DELETE FROM Exam;";
                        using (SQLiteCommand deleteCmd = new SQLiteCommand(deleteQuery, conn))
                        {
                            await deleteCmd.ExecuteNonQueryAsync();
                        }

                        // Step 2: Reset the AUTOINCREMENT ID
                        string resetQuery = "DELETE FROM sqlite_sequence WHERE name = 'Exam';";
                        using (SQLiteCommand resetCmd = new SQLiteCommand(resetQuery, conn))
                        {
                            await resetCmd.ExecuteNonQueryAsync();
                        }

                        // Commit transaction
                        transaction.Commit();
                        Console.WriteLine("All exam data cleared, and ID reset.");
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        Console.WriteLine($"Error resetting exam data: {ex.Message}");
                    }
                }
            }
        }

    }
}

    

