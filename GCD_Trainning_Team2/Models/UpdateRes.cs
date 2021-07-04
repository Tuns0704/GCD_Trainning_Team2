using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GCD_Trainning_Team2.Models
{
    public class Update_res
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string DocumentName { get; set; }
        public string AuthorName { get; set; }
        public bool IsUpdate { get; set; }

    }
}
