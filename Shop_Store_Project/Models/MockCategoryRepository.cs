using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop_Store_Project.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category {
                 CategoryID  = 1,
                 categoryName ="Fruit Pies",
                 Description = "All Fruity Pies"
                },
                new Category {
                 CategoryID  = 2,
                 categoryName ="Cheese Cakes",
                 Description = "Cheesy All The Way"
                },
                new Category {
                 CategoryID  = 3,
                 categoryName ="Seasonal Pies",
                 Description = "Get In the mood for the seasonal Pies"
                }
            };
    }
}
