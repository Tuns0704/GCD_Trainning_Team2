using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace GCD_Trainning_Team2.Models
{
    public class User : IdentityUser
    {
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
