using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicomTIC_Management_System.Models
{
    internal class Timetable
    {
        public int Id { get; set; }
        public int SubjectId { get; set; }
        public string TimeSlot { get; set; }
        public int RoomId { get; set; }
       
        

    }
}
