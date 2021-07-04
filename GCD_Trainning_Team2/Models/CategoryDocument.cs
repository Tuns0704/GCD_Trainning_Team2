using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GCD_Trainning_Team2.Models
{
    public class CategoryDocument
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int DocumentId { get; set; }
        public Document Document { get; set; }
        public DateTime CreateAt { get; set; }
        public CategoryDocument()
        {
            this.CreateAt = DateTime.Now;
        }
    }
}
