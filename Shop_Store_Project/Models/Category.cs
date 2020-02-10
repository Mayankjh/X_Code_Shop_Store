using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop_Store_Project.Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string categoryName { get; set; }
        public string Description { get; set; }
        public List<pie> Pies { get; set; }
    }
}
