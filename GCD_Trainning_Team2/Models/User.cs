using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GCD_Trainning_Team2.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public DateTime CreateAt { get; set; }

        public IList<UserRole> UserRole { get; set; }
        public IList<UpdateRes> UpdateRes { get; set; }
        public IList<AccessRes> AccessRes { get; set; }
        public User()
        {
            this.CreateAt = DateTime.Now;
        }
    }
}
