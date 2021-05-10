using AlbumShop.Data;
using AlbumShop.Data.Interfaces;
using AlbumShop.Data.Repository;
using AlbumShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumShop.Controllers
{
    public class ShopCartController : Controller
    {
        private IAllAlbums _albumRep;
        private readonly ShopCart _shopCart;
        public ShopCartController(IAllAlbums albRep, ShopCart shopCart)
        {
            _albumRep = albRep;
            _shopCart = shopCart;
        }
        public ViewResult Index()
        {
            var items = _shopCart.getShopItems();
            _shopCart.listShopItems = items;

            var obj = new ShopCartViewModel
            {
                shopCart = _shopCart
            };
            return View(obj);
        
        }
        public RedirectToActionResult addToCart(int Id)
        {
            var item = _albumRep.Albums.FirstOrDefault(i => i.Id == Id);
            if (item != null)
            {
                _shopCart.AddToCart(item);
            }
            return RedirectToAction("Index");
        }
    }

}
