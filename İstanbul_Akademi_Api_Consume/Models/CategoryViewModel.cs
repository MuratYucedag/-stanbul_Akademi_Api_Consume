using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace İstanbul_Akademi_Api_Consume.Models
{
    public class CategoryViewModel
    {
        public int CategoryID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
    }
}
