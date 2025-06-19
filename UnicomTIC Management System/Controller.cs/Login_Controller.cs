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
                var cmd = new SQLiteCommand("SELECT * FROM Student WHERE StudentName = @name AND StudentID = @id", conn);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@id", studentId);

                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    if (await reader.ReadAsync())
                    {
                        return new User
                        {
                            UserID = Convert.ToInt32(reader["StudentID"]),
                            UserName = reader["StudentName"].ToString(),
                            Password = reader["StudentID"].ToString(),
                            Role = "Student"
                        };
                    }
                }
            }


            return null;
        }
    }
}



