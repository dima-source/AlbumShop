﻿using AlbumShop.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumShop.Data
{
    public class AppDBContent : DbContext
    {
        public AppDBContent(DbContextOptions<AppDBContent> options):base(options)
        {

        }
        public DbSet<Album> Album { get; set; }
        public DbSet<Category> Category { get; set; }
    }
}
