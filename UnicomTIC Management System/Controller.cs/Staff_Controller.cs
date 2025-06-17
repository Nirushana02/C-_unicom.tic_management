using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using UnicomTIC_Management_System.Data;
using UnicomTIC_Management_System.Models;

namespace UnicomTIC_Management_System.Controller.cs
{
    internal class Staff_Controller
    {
        public async Task<List<Staff>> GetAllStaffAsync()
        {
            List<Staff> staff = new List<Staff>();

            using (var conn = DBConfig.GetConnection())
            {
                string query = @"SELECT * FROM Staff;";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (await reader.ReadAsync())
                        {
                            staff.Add(new Staff
                            {
                                StaffID = reader.GetInt32(0),
                                StaffName = reader.GetString(1),
                                PhoneNumber = reader.GetInt64(2).ToString(),
                                Gender = reader.GetString(3),
                                Status = reader.GetString(4)
                            });
                        }
                    }
                }
            }
            return staff;
        }

        public async void AddAsync(Staff staff)
        {
            using (var conn = DBConfig.GetConnection())
            {
                string query = "INSERT INTO Staff (StaffName, PhoneNumber, Gender, Status) VALUES (@name, @phone, @gender, @status);";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", staff.StaffName);
                    cmd.Parameters.AddWithValue("@phone", staff.PhoneNumber);
                    cmd.Parameters.AddWithValue("@gender", staff.Gender);
                    cmd.Parameters.AddWithValue("@status", staff.Status);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        public async void UpdateAsync(Staff staff)
        {
            using (var conn = DBConfig.GetConnection())
            {
                string query = "UPDATE Staff SET StaffName = @name, PhoneNumber = @phone, Gender = @gender, Status = @status  WHERE StaffID = @id;";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", staff.StaffName);
                    cmd.Parameters.AddWithValue("@phone", staff.PhoneNumber);
                    cmd.Parameters.AddWithValue("@gender", staff.Gender);
                    cmd.Parameters.AddWithValue("@status", staff.Status);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        public async void DeleteAsync(int id)
        {
            using (var conn = DBConfig.GetConnection())
            {
                string query = "DELETE FROM Staff WHERE StaffID = @id;";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }
    }
}
