using System;
using System.Collections.Generic;

namespace GCD_Trainning_Team2.Models
{
    public class Rating 
    {
        public int ID { get; set; }
        public int UserId { get; set; }
        public int DocumentId { get; set; }
        public int Vote { get; set; }

        public DateTime TimeAccess { get; set; }

        public IList<CategoryDocument> CategoryDocument { get; set; }
        public User Users { get; set; }
        public Rating()
        {
            this.TimeAccess = DateTime.Now;
        }
    }
}
