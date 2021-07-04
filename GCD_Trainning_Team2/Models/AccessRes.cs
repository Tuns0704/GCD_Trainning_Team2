using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GCD_Trainning_Team2.Models
{
    public class AccessRes
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int DocumentID { get; set; }
        public string Status { get; set; }

        public DateTime TimeAccess { get; set; }

        public IList<CategoryDocument> CategoryDocument { get; set; }
        public AccessRes()
        {
            this.TimeAccess = DateTime.Now;
        }
    }
}
