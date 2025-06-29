﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTIC_Management_System.Data;
using UnicomTIC_Management_System.Models;

namespace UnicomTIC_Management_System.Controller.cs
{
    internal class Mark_Controller
    {
        public async Task<List<Mark>> GetAllMarksAsync()
        {
            List<Mark> mark = new List<Mark>();

            using (var conn = DBConfig.GetConnection())
            {
                string query = @"SELECT * FROM Marks;";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (await reader.ReadAsync())
                        {
                            mark.Add(new Mark
                            {
                                MarkID = reader.GetInt32(0),
                                StudentID = reader.GetInt32(1),
                                ExamID = reader.GetInt32(2),
                                Score = reader.GetInt32(3)
                            });
                        }
                    }
                }
            }
            return mark;
        }

        public async Task<List<Mark>> GetMarksByStudentIdAsync(int studentId)
        {
            List<Mark> marks = new List<Mark>();

            using (var conn = DBConfig.GetConnection())
            {
                string query = "SELECT * FROM Marks WHERE StudentID = @sid;";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@sid", studentId);
                    using (SQLiteDataReader reader = (SQLiteDataReader)await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            marks.Add(new Mark
                            {
                                MarkID = reader.GetInt32(0),
                                StudentID = reader.GetInt32(1),
                                ExamID = reader.GetInt32(2),
                                Score = reader.GetInt32(3)
                            });
                        }
                    }
                }
            }

            return marks;
            }

        public DataTable GetStudentMarksDetailed(int studentId)
        {
            DataTable dt = new DataTable();

            using (var conn = DBConfig.GetConnection())
            {
                string query = @"
                    SELECT m.MarkID, m.StudentID, m.ExamID, m.Score
                    FROM Marks m
                    WHERE m.StudentID = @sid;";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@sid", studentId);

                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }

            return dt;
        }


        public async Task AddAsync(Mark mark)

        {
            using (var conn = DBConfig.GetConnection())
            {
                string query = "INSERT INTO Marks (StudentID, ExamID, Score) VALUES (@sid, @eid, @score);";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {

                    cmd.Parameters.AddWithValue("@sid", mark.StudentID);
                    cmd.Parameters.AddWithValue("@eid", mark.ExamID);
                    cmd.Parameters.AddWithValue("@score", mark.Score);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        public async Task UpdateAsync(Mark mark)
        {
            using (var conn = DBConfig.GetConnection())
            {
                string query = "UPDATE Marks SET StudentID = @sid, ExamID = @eid, Score = @score WHERE MarkId = @id;";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", mark.StudentID);
                    cmd.Parameters.AddWithValue("@startDate", mark.ExamID);
                    cmd.Parameters.AddWithValue("@endDate", mark.Score);
                    cmd.Parameters.AddWithValue("@id", mark.MarkID);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        public async Task DeleteAsync(int markid)
        {
            using (var conn = DBConfig.GetConnection())
            {
                string query = "DELETE FROM Marks WHERE MarkID = @id;";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", markid);
                    await cmd.ExecuteNonQueryAsync();

                }
            }
        }

        public async Task ResetMarkDataAsync()
        {
            using (var conn = DBConfig.GetConnection())
            {
                //conn.Open();

                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        // Step 1: Delete all rows from the Student table
                        string deleteQuery = "DELETE FROM Mark;";
                        using (SQLiteCommand deleteCmd = new SQLiteCommand(deleteQuery, conn))
                        {
                            await deleteCmd.ExecuteNonQueryAsync();
                        }

                        // Step 2: Reset the AUTOINCREMENT ID
                        string resetQuery = "DELETE FROM sqlite_sequence WHERE name = 'Mark';";
                        using (SQLiteCommand resetCmd = new SQLiteCommand(resetQuery, conn))
                        {
                            await resetCmd.ExecuteNonQueryAsync();
                        }

                        // Commit transaction
                        transaction.Commit();
                        Console.WriteLine("All mark data cleared, and ID reset.");
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
