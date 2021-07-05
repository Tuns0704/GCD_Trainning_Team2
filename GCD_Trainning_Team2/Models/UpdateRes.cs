using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GCD_Trainning_Team2.Models
{
    public class UpdateRes
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string DocumentName { get; set; }
        public string AuthorName { get; set; }
        public bool IsUpdate { get; set; }

        public User Users { get; set; }


    }
}
