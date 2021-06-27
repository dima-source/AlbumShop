using AlbumShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumShop.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Album> favAlbums { get; set; }
    }
}
