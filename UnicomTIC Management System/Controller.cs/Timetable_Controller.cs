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
                                Id = reader.GetInt32(0),
                                SubjectId = reader.GetInt32(1),
                                TimeSlot = reader.GetString(2),
                                RoomId = reader.GetInt32(3)
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
                string query = "INSERT INTO Timetable (SubjectId, TimeSlot, RoomId) VALUES (@sub, @slot, @room);";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@sub", timetable.SubjectId);
                    cmd.Parameters.AddWithValue("@slot", timetable.TimeSlot);
                    cmd.Parameters.AddWithValue("@room", timetable.RoomId);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        public async Task UpdateAsync(Timetable timetable)
        {
            using (var conn =  DBConfig.GetConnection())
            {
                string query = "UPDATE Timetable SET SubjectId = @sub, TimeSlot = @slot, RoomId = @room WHERE Id = @id;";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@sub", timetable.SubjectId);
                    cmd.Parameters.AddWithValue("@slot", timetable.TimeSlot);
                    cmd.Parameters.AddWithValue("@room", timetable.RoomId);
                    cmd.Parameters.AddWithValue("@id", timetable.Id);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        public async Task DeleteAsync(int id)
        {
            using (var conn =  DBConfig.GetConnection())
            {
                string query = "DELETE FROM Timetable WHERE Id = @id;";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }
    }
}
