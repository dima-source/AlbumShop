using AlbumShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumShop.Data
{
    public class ShopCartItem
    {
        public int Id { get; set; }
        public Album album { get; set; }
        public int price { get; set; }
        public string ShopCartId { get; set; }
    }
}
