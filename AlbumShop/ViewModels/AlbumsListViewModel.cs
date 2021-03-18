using AlbumShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumShop.ViewModels
{
    public class AlbumsListViewModel
    {
        public IEnumerable<Album> GetAllAlbums { get; set; }
        public string AlbumCategory { get; set; }
    }
}
