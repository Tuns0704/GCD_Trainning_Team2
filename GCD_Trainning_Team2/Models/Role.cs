using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GCD_Trainning_Team2.Models
{
    public class Role
    {
        public int Id { get; set; }
        public string RoleName { get; set; }

        public IList<UserRole> UserRole { get; set; }

    }
}
