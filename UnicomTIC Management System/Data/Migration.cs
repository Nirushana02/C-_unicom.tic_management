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
                                CREATE TABLE IF NOT EXISTS Student (ID INTEGER PRIMARY KEY AUTOINCREMENT,
                                                                   StudentName TEXT, 
                                                                   CourseID INTEGER,FOREIGN KEY(CourseId) REFERENCES Course(CourseId));

                                CREATE TABLE IF NOT EXISTS User (ID INTEGER PRIMARY KEY AUTOINCREMENT,
                                                                Role TEXT,UserName TEXT,
                                                                Password STRING );
                                
                                CREATE TABLE IF NOT EXISTS Course (CourseID INTEGER PRIMARY KEY AUTOINCREMENT,
                                                                    CourseName TEXT NOT NULL,
                                                                    StartDate DATE NOT NULL, 
                                                                    EndDate DATE NOT NULL);
                                
                                CREATE TABLE IF NOT EXISTS Timetable (TimetableID INTEGER PRIMARY KEY AUTOINCREMENT, 
                                                                        SubjectName TEXT NOT NULL,
                                                                        TimeSlot TEXT NOT NULL,
                                                                        RoomName TEXT NOT NULL,
                                                                        FOREIGN KEY(SubjectId) REFERENCES Subject(SubjectID),
                                                                        FOREIGN KEY(RoomId) REFERENCES Room(RoomID));

                                CREATE TABLE IF NOT EXISTS Lecture (LectureID INTEGER PRIMARY KEY AUTOINCREMENT, 
                                                                        LectureName TEXT NOT NULL,
                                                                        Address TEXT NOT NULL);

                                CREATE TABLE IF NOT EXISTS Exam (ExamID INTEGER PRIMARY KEY AUTOINCREMENT, 
                                                                        ExamName TEXT NOT NULL,
                                                                        SubjectID INTEGER,
                                                                        FOREIGN KEY(SubjectID) REFERENCES Subject(SubjectID));

                                CREATE TABLE IF NOT EXISTS Room (RoomID INTEGER PRIMARY KEY AUTOINCREMENT, 
                                                                        RoomName TEXT NOT NULL,
                                                                        RoomType TEXT NOT NULL);

                                CREATE TABLE IF NOT EXISTS Marks (MarkID INTEGER PRIMARY KEY,
                                                                    StudentID INTEGER,
                                                                    ExamID INTEGER,
                                                                    Score INTEGER,
                                                                    FOREIGN KEY(StudentID) REFERENCES Student(StudentID),
                                                                    FOREIGN KEY(ExamID) REFERENCES Exam(ExamID));
                

                                                                
                        
                               ";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
