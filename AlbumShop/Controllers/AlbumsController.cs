using AlbumShop.Data.Interfaces;
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

        public ViewResult List()
        {
            ViewBag.Title = "Страница с альбомами";
            AlbumsListViewModel obj = new AlbumsListViewModel();
            obj.GetAllAlbums = _allAlbums.Albums;
            obj.AlbumCategory = "Альбом";

            return View(obj);
        }
    }
}
