using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GCD_Trainning_Team2.Models
{
    public class Chapter
    {
        public int Id { get; set; }
        public int DocumentId { get; set; }
        public string Content { get; set; }
        public Document Document { get; set; }
    }
}
