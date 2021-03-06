using AlbumShop.Data.Interfaces;
using AlbumShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumShop.Data.Repository
{
    public class CategoryRepository : IAlbumCategory
    {
        private readonly ApplicationContext appDBContent;
        public CategoryRepository(ApplicationContext appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<Category> AllCaregories => appDBContent.Category;
    }
}
