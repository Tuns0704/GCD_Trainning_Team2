using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace GCD_Trainning_Team2.Models
{
    public class User : IdentityUser
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string E_mail { get; set; }
        public string Password { get; set; }
        public DateTime CreateAt { get; set; }
        [NotMapped]
        public string Role { get; set; }

        public IList<UpdateRes> UpdateRes { get; set; }
        public IList<AccessRes> AccessRes { get; set; }
        public User()
        {
            this.CreateAt = DateTime.Now;
        }
    }
}
