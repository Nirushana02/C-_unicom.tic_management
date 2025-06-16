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
                                RoomId = reader.GetInt32(0),
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
                    cmd.Parameters.AddWithValue("@id", room.RoomId);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        public async Task DeleteAsync(int id)
        {
            using (var conn = DBConfig.GetConnection())
            {
                string query = "DELETE FROM Room WHERE RoomID = @id;";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }
    }
}
