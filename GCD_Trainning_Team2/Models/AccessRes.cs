using System;
using System.Collections.Generic;


namespace GCD_Trainning_Team2.Models
{
    public class AccessRes 
    {
        public int ID { get; set; }
        public int UserId { get; set; }
        public int DocumentID { get; set; }
        public string Status { get; set; }

        public DateTime TimeAccess { get; set; }

        public IList<CategoryDocument> CategoryDocument { get; set; }
        public User Users { get; set; }
        public AccessRes()
        {
            this.TimeAccess = DateTime.Now;
        }
    }
}
