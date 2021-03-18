using AlbumShop.Data.Interfaces;
using AlbumShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumShop.Data.Mock
{
    public class MockCategory : IAlbumCategory
    {
        public IEnumerable<Category> AllCaregories
        {
            get
            {
                return new List<Category>
                {
                    new Category{CategoryName = "K-POP", Desc ="Корейская поп музыка"},
                    new Category{CategoryName = "Рок", Desc ="Рок музыка"}

                };
            }
        }

    }
}
