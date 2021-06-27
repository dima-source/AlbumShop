using AlbumShop.Data.Interfaces;
using AlbumShop.Data.Models;
using AlbumShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumShop.Controllers
{
    public class AlbumsController : Controller
    {
        private readonly IAllAlbums _allAlbums;
        private readonly IAlbumCategory _allCategories;
         
        public AlbumsController(IAllAlbums iAllAlbums, IAlbumCategory ialbumCat)
        {
            _allAlbums = iAllAlbums;
            _allCategories = ialbumCat;
        }
        [Route("Albums/List")]
        [Route("Albums/List/{category}")]
        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Album> albums;
            string currCategory = "";

            if (string.IsNullOrEmpty(category))
            {
                albums = _allAlbums.Albums.OrderBy(i => i.Id);
            }
            else
            {
                if (string.Equals("K-POP", category, StringComparison.OrdinalIgnoreCase))
                {
                    albums = _allAlbums.Albums.Where(i => i.Category.CategoryName.Equals("K-POP")).OrderBy(i => i.Id);

                }
                else
                {
                    albums = _allAlbums.Albums.Where(i => i.Category.CategoryName.Equals("Рок")).OrderBy(i => i.Id);
                }
                currCategory = _category;
               
            }
            var albumObj = new AlbumsListViewModel
            {
                GetAllAlbums = albums,
                AlbumCategory = currCategory
            };
            ViewBag.Title = "Страница с альбомами";
           

            return View(albumObj);
        }
    }
}
