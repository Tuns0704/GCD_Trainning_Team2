using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GCD_Trainning_Team2.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public IList<CategoryDocument> CategoryDocument { get; set; }
    }
}
