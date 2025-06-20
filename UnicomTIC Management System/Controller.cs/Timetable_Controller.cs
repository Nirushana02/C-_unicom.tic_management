using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using UnicomTIC_Management_System.Data;
using UnicomTIC_Management_System.Models;

namespace UnicomTIC_Management_System.Controller.cs
{
    internal class Timetable_Controller
    {
        public async Task<List<Timetable>> show_TimetableAsync()
        {
            List<Timetable> timetable = new List<Timetable>();

            using (var conn =  DBConfig.GetConnection())
            {
                string query = @"SELECT * FROM Timetable;";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    using (SQLiteDataReader reader =  cmd.ExecuteReader())
                    {
                        while (await reader.ReadAsync())
                        {
                            timetable.Add(new Timetable
                            {
                                TimetableID = reader.GetInt32(0),
                                SubjectID = reader.GetInt32(1),
                                TimeSlot = reader.GetString(2),
                                RoomID = reader.GetInt32(3)
                            });
                        }

                    }
                }
                
            }
            return timetable;
        }

        public async Task AddAsync(Timetable timetable)
        {
            using (var conn =  DBConfig.GetConnection())
            {
                string query = "INSERT INTO Timetable (SubjectID, TimeSlot, RoomID) VALUES (@sub, @slot, @room);";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@sub", timetable.SubjectID);
                    cmd.Parameters.AddWithValue("@slot", timetable.TimeSlot);
                    cmd.Parameters.AddWithValue("@room", timetable.RoomID);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        public async Task UpdateAsync(Timetable timetable)
        {
            using (var conn =  DBConfig.GetConnection())
            {
                string query = "UPDATE Timetable SET SubjectID = @sub, TimeSlot = @slot, RoomID = @room WHERE Id = @id;";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@sub", timetable.SubjectID);
                    cmd.Parameters.AddWithValue("@slot", timetable.TimeSlot);
                    cmd.Parameters.AddWithValue("@room", timetable.RoomID);
                    cmd.Parameters.AddWithValue("@id", timetable.TimetableID);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        public async Task DeleteAsync(int id)
        {
            using (var conn =  DBConfig.GetConnection())
            {
                string query = "DELETE FROM Timetable WHERE TimetableId = @id;";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        public async Task ResetTimetableDataAsync()
        {
            using (var conn = DBConfig.GetConnection())
            {
                //conn.Open();

                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        // Step 1: Delete all rows from the Student table
                        string deleteQuery = "DELETE FROM Timetable;";
                        using (SQLiteCommand deleteCmd = new SQLiteCommand(deleteQuery, conn))
                        {
                            await deleteCmd.ExecuteNonQueryAsync();
                        }

                        // Step 2: Reset the AUTOINCREMENT ID
                        string resetQuery = "DELETE FROM sqlite_sequence WHERE name = 'Timetable';";
                        using (SQLiteCommand resetCmd = new SQLiteCommand(resetQuery, conn))
                        {
                            await resetCmd.ExecuteNonQueryAsync();
                        }

                        // Commit transaction
                        transaction.Commit();
                        Console.WriteLine("All timetable data cleared, and ID reset.");
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        Console.WriteLine($"Error resetting timetable data: {ex.Message}");
                    }
                }
            }
        }
    }
}
