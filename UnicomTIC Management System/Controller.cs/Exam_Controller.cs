using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTIC_Management_System.Data;
using UnicomTIC_Management_System.Models;

namespace UnicomTIC_Management_System.Controller.cs
{
    internal class Exam_Controller
    {
        public async Task<List<Exam>> GetAllExamAsync()
        {
            List<Exam> exam = new List<Exam>();

            using (var conn = DBConfig.GetConnection())
            {
                string query = @"SELECT * FROM Exam;";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (await reader.ReadAsync())
                        {
                            exam.Add(new Exam
                            {
                                ExamId = reader.GetInt32(0),
                                ExamName = reader.GetString(1),
                                SubjectId = reader.GetInt32(2)
                                
                            });
                        }
                    }
                }
            }
            return exam;
        }

        public async Task AddAsync(Exam exam)
        { 
            using (var conn = DBConfig.GetConnection())
            {
                string query = "INSERT INTO Exam (ExamName, SubjectId) VALUES (@name, @sbjectId);";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", exam.ExamName);
                    cmd.Parameters.AddWithValue("@subjectId", exam.SubjectId);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        public async Task UpdateAsync(Exam exam)
        {
            using (var conn = DBConfig.GetConnection())
            {
                string query = "Update Exam SET (ExamName = @name, SubjectId = @sbjectId WHERE ExamId = @id;";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", exam.ExamName);
                    cmd.Parameters.AddWithValue("@subjectId", exam.SubjectId);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        public async Task DeleteAsync(int examid)
        {
            using (var conn = DBConfig.GetConnection())
            {
                string query = "DELETE FROM Exam WHERE ExamId = @id;";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", examid);
                    await cmd.ExecuteNonQueryAsync();

                }
            }
        }

    }
}

    

