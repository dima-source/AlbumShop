using AlbumShop.Data.Interfaces;
using AlbumShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumShop.Data.Mock
{
    public class MockAlbum : IAllAlbums
    {
        private readonly IAlbumCategory _categoryAlbums = new MockCategory();
        public IEnumerable<Album> Albums 
        {
            get
            {
                return new List<Album>
                {
                    new Album
                    {
                        Name = "Tear",
                        ShortDesc = "Грустный",
                        LongDesc = "Альбом про неразделенную любовь",
                        IMG = "/img/tear.jpg",
                        Price = 30,
                        IsFavorite = true,
                        Group = "BTS",
                        CountTrack = 11,
                        Available = true,
                        Category = _categoryAlbums.AllCaregories.First()
                    },
                    new Album
                    {
                        Name = "Her",
                        ShortDesc = "Веселый",
                        LongDesc = "Посвященный девушке",
                        IMG = "/img/her.jpg",
                        Price = 30,
                        IsFavorite = true,
                        Group = "BTS",
                        CountTrack = 11,
                        Available = true,
                        Category = _categoryAlbums.AllCaregories.First()
                    },
                    new Album
                    {
                        Name = "Answer",
                        ShortDesc = "Сборник",
                        LongDesc = "Сборник оучших песен LY",
                        IMG = "/img/answer.jpg",
                        Price = 30,
                        IsFavorite = true,
                        Group = "BTS",
                        CountTrack = 26,
                        Available = true,
                        Category = _categoryAlbums.AllCaregories.First()
                    },
                    new Album
                    {
                        Name = "Rise",
                        ShortDesc = "Металл",
                        LongDesc = "Один из лучших альбомов группы",
                        IMG = "/img/rise.jpg",
                        Price = 20,
                        IsFavorite = true,
                        Group = "Skillet",
                        CountTrack = 12,
                        Available = true,
                        Category = _categoryAlbums.AllCaregories.Last()
                    },
                    new Album
                    {
                        Name = "Comatose",
                        ShortDesc = "Металл",
                        LongDesc = "Один из лучших альбомов группы",
                        IMG = "/img/comatose.jpg",
                        Price = 20,
                        IsFavorite = true,
                        Group = "Skillet",
                        CountTrack = 11,
                        Available = true,
                        Category = _categoryAlbums.AllCaregories.Last()
                    }



                };
            }
           
        }
        public IEnumerable<Album> GetFavAlbums { get ; set; }

        public Album GetObjectAlbum(int AlbumId)
        {
            throw new NotImplementedException();
        }
    }
}
