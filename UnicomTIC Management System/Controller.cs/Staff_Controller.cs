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
                                PhoneNumber = reader.GetString(2),
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

        public async Task ResetStaffDataAsync()
        {
            using (var conn = DBConfig.GetConnection())
            {
                //conn.Open();

                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        // Step 1: Delete all rows from the Student table
                        string deleteQuery = "DELETE FROM Staff;";
                        using (SQLiteCommand deleteCmd = new SQLiteCommand(deleteQuery, conn))
                        {
                            await deleteCmd.ExecuteNonQueryAsync();
                        }

                        // Step 2: Reset the AUTOINCREMENT ID
                        string resetQuery = "DELETE FROM sqlite_sequence WHERE name = 'Staff';";
                        using (SQLiteCommand resetCmd = new SQLiteCommand(resetQuery, conn))
                        {
                            await resetCmd.ExecuteNonQueryAsync();
                        }

                        // Commit transaction
                        transaction.Commit();
                        Console.WriteLine("All staff data cleared, and ID reset.");
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        Console.WriteLine($"Error resetting staff data: {ex.Message}");
                    }
                }
            }
        }
    }
}
