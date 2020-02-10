using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop_Store_Project.Models
{
    public interface IPieRepository
    {
        IEnumerable<pie> AllPies { get; }

        IEnumerable<pie> PiesOfTheWeek { get; }
        pie GetPieById(int pieId);

    }
}
