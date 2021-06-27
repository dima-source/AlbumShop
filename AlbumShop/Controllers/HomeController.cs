using AlbumShop.Data.Interfaces;
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
            return View();
        }
    }
}
