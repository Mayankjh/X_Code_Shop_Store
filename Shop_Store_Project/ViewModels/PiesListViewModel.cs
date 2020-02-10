using Shop_Store_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop_Store_Project.ViewModels
{
    public class PiesListViewModel
    {
        public IEnumerable<pie> Pies { get; set; }
        public string CurrentCategory { get; set; }
    }
}
