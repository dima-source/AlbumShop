using AlbumShop.Data.Interfaces;
using AlbumShop.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumShop.Data.Repository
{
    public class AlbumRepository : IAllAlbums
    {
        private readonly ApplicationContext appDBContent;
        public AlbumRepository(ApplicationContext appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<Album> Albums => appDBContent.Album.Include(c => c.Category);

        public IEnumerable<Album> GetFavAlbums => appDBContent.Album.Where(p => p.IsFavorite).Include(c => c.Category);

        public Album GetObjectAlbum(int AlbumId) => appDBContent.Album.FirstOrDefault(p => p.Id == AlbumId);
        
    }
}
