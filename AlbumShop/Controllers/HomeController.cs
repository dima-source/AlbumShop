using AlbumShop.Data.Interfaces;
using AlbumShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumShop.Controllers
{
    public class HomeController : Controller
    {
        private IAllAlbums _albumRep;
        
        public HomeController(IAllAlbums albRep)
        {
            _albumRep = albRep;
            
        }
        public ViewResult Index()
        {
            var homeAlbums = new HomeViewModel
            {
                favAlbums = _albumRep.GetFavAlbums
            };
            return View(homeAlbums);
        }
    }
}
