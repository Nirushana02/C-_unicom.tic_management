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
    internal class Room_Controller
    {
        public async Task<List<Room>> GetAllAsync()
        {
            List<Room> room = new List<Room>();

            using (var conn = DBConfig.GetConnection())
            {
                string query = @"SELECT * FROM Room;";
               
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (await reader.ReadAsync())
                        {
                            room.Add(new Room
                            {
                                RoomID = reader.GetInt32(0),
                                RoomName = reader.GetString(1),
                                RoomType = reader.GetString(2)
                            });
                        }
                    }
                }
            }

            return room;
        }

        public async Task AddAsync(Room room)
        {
            using (var conn = DBConfig.GetConnection())
            {
                string query = "INSERT INTO Room (RoomName, RoomType) VALUES (@name, @type);";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", room.RoomName);
                    cmd.Parameters.AddWithValue("@type", room.RoomType);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        public async Task UpdateAsync(Room room)
        {
            using (var conn = DBConfig.GetConnection())
            {
                string query = "UPDATE Room SET RoomName = @name, RoomType = @type WHERE RoomID = @id;";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                { 
                    cmd.Parameters.AddWithValue("@name", room.RoomName);
                    cmd.Parameters.AddWithValue("@type", room.RoomType);
                    cmd.Parameters.AddWithValue("@id", room.RoomID);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        public async Task DeleteAsync(int roomid)
        {
            using (var conn = DBConfig.GetConnection())
            {
                string query = "DELETE FROM Room WHERE RoomID = @id;";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", roomid);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        public async Task ResetRoomDataAsync()
        {
            using (var conn = DBConfig.GetConnection())
            {
                //conn.Open();

                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        // Step 1: Delete all rows from the Student table
                        string deleteQuery = "DELETE FROM Room;";
                        using (SQLiteCommand deleteCmd = new SQLiteCommand(deleteQuery, conn))
                        {
                            await deleteCmd.ExecuteNonQueryAsync();
                        }

                        // Step 2: Reset the AUTOINCREMENT ID
                        string resetQuery = "DELETE FROM sqlite_sequence WHERE name = 'Room';";
                        using (SQLiteCommand resetCmd = new SQLiteCommand(resetQuery, conn))
                        {
                            await resetCmd.ExecuteNonQueryAsync();
                        }

                        // Commit transaction
                        transaction.Commit();
                        Console.WriteLine("All room data cleared, and ID reset.");
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        Console.WriteLine($"Error resetting room data: {ex.Message}");
                    }
                }
            }
        }
    }
}
