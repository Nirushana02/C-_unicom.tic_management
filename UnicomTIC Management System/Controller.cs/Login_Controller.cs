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

        public Login_Controller(User user)
        {
            using (var conn = DBConfig.GetConnection())
            {
                string query = "INSERT INTO User (role, name, password) VALUES ('Admin','admin','admin123')" +
                                                                                "('Student', 'student', 'student123')" +
                                                                                "('Lecture', 'lecture', 'lecture123')" +
                                                                                "('Staff', 'staff', 'staff123');";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Role", user.Role);
                    cmd.Parameters.AddWithValue("@Name", user.Name);
                    cmd.Parameters.AddWithValue("@Password", user.Password);
                    cmd.ExecuteNonQuery();
                }

            }
        }
    }
}

