using AlbumShop.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumShop.Data
{
    public class DBObjects
    {
        public static void Initial(ApplicationContext content)
        {
            
           
            if(!content.Category.Any())
            {
                content.Category.AddRange(Categories.Select(c => c.Value));
            }
            if(!content.Album.Any())
            {
                content.AddRange(
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
                        Category = Categories["K-POP"]
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
                        Category = Categories["K-POP"]
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
                        Category = Categories["Рок"]
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
                        Category = Categories["Рок"]
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
                        Category = Categories["Рок"]
                    }
                    );
            }
            content.SaveChanges();
        }
        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if(category == null)
                {
                    var list = new Category[]
                    {
                        new Category{CategoryName = "K-POP", Desc ="Корейская поп музыка"},
                        new Category{CategoryName = "Рок", Desc ="Рок музыка"}
                    };
                    category = new Dictionary<string, Category>();
                    foreach(Category el in list)
                    {
                        category.Add(el.CategoryName, el);
                    }
                }
                return category;
            }
        }
    }
}
