using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GCD_Trainning_Team2.Models
{
    public class Document
    {
        public int Id { get; set; }
        public int RatingId { get; set; }
        public int CategoryId { get; set; }
        public int ChapterId { get; set; }
        public int AuthorId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public IList<CategoryDocument> CategoryDocument { get; set; }
    }
}
