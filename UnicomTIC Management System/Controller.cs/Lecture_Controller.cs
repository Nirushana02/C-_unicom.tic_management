using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTIC_Management_System.Data;
using UnicomTIC_Management_System.Models;

namespace UnicomTIC_Management_System.Controller.cs
{
    internal class Lecture_Controller
    {
        public async Task<List<Lecture>> GetLecturesAsync()
        {
            List<Lecture> lectures = new List<Lecture>();

            using (var conn = DBConfig.GetConnection())
            {
                string query = "SELECT * FROM Lecture;";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (await reader.ReadAsync())
                        {
                            lectures.Add(new Lecture
                            {
                                LectureID = reader.GetInt32(0),
                                LectureName = reader.GetString(1),
                                Address = reader.GetString(2)
                            });

                        }
                    }
                }
            }
            return lectures;
        }
       

        public async Task AddAsync(Lecture lecture)
        {
            using (var conn = DBConfig.GetConnection())
            {
                string query = "INSERT INTO Lecture (LectureName,Address) VALUES (@LectureName, @Address);";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@LectureName", lecture.LectureName);
                    cmd.Parameters.AddWithValue("@Address", lecture.Address);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        public async Task UpdateAsync(Lecture lecture)
        {
            using (var conn = DBConfig.GetConnection())
            {
                string query = "UPDATE Lecture SET LectureName = @name, Address = @address WHERE LectureId = @id;";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@LectureName", lecture.LectureName);
                    cmd.Parameters.AddWithValue("@Address", lecture.Address);
                    cmd.Parameters.AddWithValue("@LectureId", lecture.LectureID);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        public async Task DeleteAsync(int lectureid)
        {
            using (var conn = DBConfig.GetConnection())
            {
                string query = "DELETE FROM Lecture WHERE LectureID = @id;";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", lectureid);
                    await cmd.ExecuteNonQueryAsync();

                }
            }
        }

        public async Task ResetLectureDataAsync()
        {
            using (var conn = DBConfig.GetConnection())
            {
                //conn.Open();

                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        // Step 1: Delete all rows from the Student table
                        string deleteQuery = "DELETE FROM Lecture;";
                        using (SQLiteCommand deleteCmd = new SQLiteCommand(deleteQuery, conn))
                        {
                            await deleteCmd.ExecuteNonQueryAsync();
                        }

                        // Step 2: Reset the AUTOINCREMENT ID
                        string resetQuery = "DELETE FROM sqlite_sequence WHERE name = 'Lecture';";
                        using (SQLiteCommand resetCmd = new SQLiteCommand(resetQuery, conn))
                        {
                            await resetCmd.ExecuteNonQueryAsync();
                        }

                        // Commit transaction
                        transaction.Commit();
                        Console.WriteLine("All lecture data cleared, and ID reset.");
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        Console.WriteLine($"Error resetting lecture data: {ex.Message}");
                    }
                }
            }
        }
    }
}
