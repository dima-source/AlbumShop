using AlbumShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumShop.Data.Interfaces
{
    public interface IAllAlbums
    {
        IEnumerable<Album> Albums { get; }
        IEnumerable<Album> GetFavAlbums { get; set; }
        Album GetObjectAlbum(int AlbumId); 
    }
}
