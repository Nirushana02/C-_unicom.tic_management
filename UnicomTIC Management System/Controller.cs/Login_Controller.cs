using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using UnicomTIC_Management_System.Data;
using UnicomTIC_Management_System.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace UnicomTIC_Management_System.Controller.cs
{
    internal class Login_Controller
    {
        public Login_Controller() { }

        public async Task<User> ValidateStudentAsync(string name, string studentId)
        {
            using (var conn = DBConfig.GetConnection())
            {
                //ait conn.OpenAsync();
                var cmd = new SQLiteCommand("SELECT * FROM Student WHERE StudentName = @name AND StudentID = @id", conn);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@id", studentId);

                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    if (await reader.ReadAsync())
                    {
                        var user = new User
                        {
                            UserID = Convert.ToInt32(reader["StudentID"]),
                            Name = reader["StudentName"].ToString(),
                            Password = reader["StudentID"].ToString(),
                            Role = "Student"
                        };

                        return user;
                    }
                }
            }

            return null;
        }

        public async Task<User> ValidateUserAsync(string name, string password)
        {
            using (var conn = DBConfig.GetConnection())
            {
                var cmd = new SQLiteCommand("SELECT * FROM User WHERE Name = @name AND Password = @password", conn);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@password", password);

                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    if (await reader.ReadAsync())
                    {
                        return new User
                        {
                            UserID = Convert.ToInt32(reader["UserID"]),
                            Name = reader["Name"].ToString(),
                            Password = reader["Password"].ToString(),
                            Role = reader["Role"].ToString()
                        };
                    }
                }
            }

            return null;
        }

       
    }
}



