using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicomTIC_Management_System.Data
{
    internal class Migration
    {
        public void Create_Table()
        {
            using (var conn = DBConfig.GetConnection())
            {
                string query = @"
                                CREATE TABLE IF NOT EXISTS Student (Id INTEGER PRIMARY KEY AUTOINCREMENT,
                                                                   Name TEXT, 
                                                                   CourseId INTEGER,FOREIGN KEY(CourseId) REFERENCES Course(CourseId));

                                CREATE TABLE IF NOT EXISTS User (ID INTEGER PRIMARY KEY AUTOINCREMENT,
                                                                Role TEXT,Name TEXT,
                                                                Password STRING );
                                
                                CREATE TABLE IF NOT EXISTS Course (ID INTEGER PRIMARY KEY AUTOINCREMENT,
                                                                    CourseName TEXT NOT NULL,
                                                                    StartDate DATE NOT NULL, 
                                                                    EndDate DATE NOT NULL);
                                
                                CREATE TABLE IF NOT EXISTS Timetable (ID INTEGER PRIMARY KEY AUTOINCREMENT, 
                                                                        SubjectId INTEGER,
                                                                        TimeSlot TEXT NOT NULL,
                                                                        RoomId INTEGER,
                                                                        FOREIGN KEY(SubjectId) REFERENCES Subjects(SubjectId),
                                                                        FOREIGN KEY(RoomId) REFERENCES Rooms(RoomId));

                                CREATE TABLE IF NOT EXISTS Lecture (LectureID INTEGER PRIMARY KEY AUTOINCREMENT, 
                                                                        LectureName TEXT NOT NULL,
                                                                        Address TEXT NOT NULL);

                                CREATE TABLE IF NOT EXISTS Exam (ExamID INTEGER PRIMARY KEY AUTOINCREMENT, 
                                                                        ExamName TEXT NOT NULL,
                                                                        SubjectID INTEGER,
                                                                        FOREIGN KEY(SubjectId) REFERENCES Subjects(SubjectId));

                                CREATE TABLE IF NOT EXISTS Room (RoomID INTEGER PRIMARY KEY AUTOINCREMENT, 
                                                                        RoomName TEXT NOT NULL,
                                                                        RoomType TEXT NOT NULL);

                                CREATE TABLE IF NOT EXISTS Marks (MarkID INTEGER PRIMARY KEY,
                                                                    StudentId INTEGER,
                                                                    ExamId INTEGER,
                                                                    Score INTEGER,
                                                                    FOREIGN KEY(StudentId) REFERENCES Students(StudentId),
                                                                    FOREIGN KEY(ExamId) REFERENCES Exams(ExamId));
                

                                                                
                        
                               ";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
