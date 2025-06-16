using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTIC_Management_System.Data;
using UnicomTIC_Management_System.Models;

namespace UnicomTIC_Management_System.Controller.cs
{
    internal class Mark_Controller
    {
        public async Task<List<Mark>> GetAllMarksAsync()
        {
            List<Mark> mark = new List<Mark>();

            using (var conn = DBConfig.GetConnection())
            {
                string query = @"SELECT * FROM Mark;";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (await reader.ReadAsync())
                        {
                            mark.Add(new Mark
                            {
                                MarkID = reader.GetInt32(0),
                                StudentID = reader.GetInt32(1),
                                ExamID = reader.GetInt32(2),
                                Score = reader.GetInt32(3)
                            });
                        }
                    }
                }
            }
            return mark;
        }

        /*public async Task<DataTable> GetAllMarksByStudentAsync(string username)
        {
            DataTable marksTable = new DataTable();

            using (var conn = DBConfig.GetConnection())
            {
                await conn.OpenAsync();
                string query = @"
                    SELECT 
                        Mark.MarkID AS 'Mark ID',
                        Mark.StudentID AS 'Student ID',
                        Mark.ExamID AS 'Exam ID',
                        Mark.Score AS 'Score'
                    FROM 
                        Mark
                    INNER JOIN 
                        Students ON Mark.StudentID = Students.Id
                    WHERE 
                        Students.Username = @username;";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);

                    using (var adapter = new SQLiteDataAdapter(cmd))
                    {
                        adapter.Fill(marksTable);
                    }
                }
            }

            return marksTable;
        }*/

        public async Task AddAsync(Mark mark)

        {
            using (var conn = DBConfig.GetConnection())
            {
                string query = "INSERT INTO Mark (StudentID, ExamID, Score) VALUES (@sid, @eid, @score);";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {

                    cmd.Parameters.AddWithValue("@sid", mark.StudentID);
                    cmd.Parameters.AddWithValue("@eid", mark.ExamID);
                    cmd.Parameters.AddWithValue("@score", mark.Score);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        public async Task UpdateAsync(Mark mark)
        {
            using (var conn = DBConfig.GetConnection())
            {
                string query = "UPDATE Mark SET StudentID = @sid, ExamID = @eid, Score = @score WHERE Id = @id;";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", mark.StudentID);
                    cmd.Parameters.AddWithValue("@startDate", mark.ExamID);
                    cmd.Parameters.AddWithValue("@endDate", mark.Score);
                    cmd.Parameters.AddWithValue("@id", mark.MarkID);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        public async Task DeleteAsync(int markid)
        {
            using (var conn = DBConfig.GetConnection())
            {
                string query = "DELETE FROM Mark WHERE MarkId = @id;";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", markid);
                    await cmd.ExecuteNonQueryAsync();

                }
            }
        }
    }
}
