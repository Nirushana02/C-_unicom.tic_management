using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicomTIC_Management_System.Models
{
    internal class User
    {
        public int UserID { get; set; }
        public string Role { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
       
    }
}
