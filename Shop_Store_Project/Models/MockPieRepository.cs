using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop_Store_Project.Models
{
    public class MockPieRepository: IPieRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();
        public IEnumerable<pie> AllPies =>
            new List<pie>
            {
                new pie { PieID = 1,
                          Name = "Strawberry Pie",
                          Price=15.99M,
                          ShortDescription="Lorem Ipsum",
                          LongDescription ="Long Long Description",
                          AllergyInformation = "None",
                          Category= _categoryRepository.AllCategories.ToList()[0],
                          ImageUrl="https://food.fnr.sndimg.com/content/dam/images/food/fullset/2013/6/28/0/FNK_Apple-Pie_s4x3.jpg.rend.hgtvcom.616.462.suffix/1382545039107.jpeg",
                          InStock=true,
                          IsPieOfTheWeek=false },
                new pie { PieID = 2,
                          Name = "Cheese Cake",
                          Price=18.99M,
                          ShortDescription="Lorem Ipsum",
                          LongDescription ="Long Long Description",
                          AllergyInformation = "None",
                          Category= _categoryRepository.AllCategories.ToList()[1],
                          ImageUrl="https://i2.wp.com/www.sugarspunrun.com/wp-content/uploads/2019/01/Best-Cheesecake-Recipe-2-1-of-1-4.jpg",
                          InStock=true,
                          IsPieOfTheWeek=true },
                new pie { PieID = 3,
                          Name = "Rhubarb Pie",
                          Price=13.99M,
                          ShortDescription="Lorem Ipsum",
                          LongDescription ="Long Long Description",
                          AllergyInformation = "None",
                          Category= _categoryRepository.AllCategories.ToList()[0],
                          ImageUrl="https://www.chatelaine.com/wp-content/uploads/2018/05/Strawberry-Rhubarb-Pie-1x1.jpg",
                          InStock=false,
                          IsPieOfTheWeek=false }, 
                new pie { PieID = 4,
                          Name = "Pumpkin Pie",
                          Price=19.99M,
                          ShortDescription="Lorem Ipsum",
                          LongDescription ="Long Long Description",
                          AllergyInformation = "None",
                          Category= _categoryRepository.AllCategories.ToList()[2],
                          ImageUrl="https://www.tasteofhome.com/wp-content/uploads/2018/01/Traditional-Pumpkin-Pie_EXPS_CWON19_9287_E06_07_3b-1.jpg",
                          InStock=true,
                          IsPieOfTheWeek=false }
            };
        public IEnumerable<pie> PiesOfTheWeek { get; }
        public pie GetPieById(int pieId)
        {
            return AllPies.FirstOrDefault(p => p.PieID == pieId);
        }
    }
}
