using AlbumShop.Data;
using AlbumShop.Data.Interfaces;
using AlbumShop.Data.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumShop.Controllers
{
    public class OrderController : Controller
    {
        private readonly IAllOrders allOrders;
        private readonly ShopCart shopCart;
        public OrderController(IAllOrders allOrders, ShopCart shopCart)
        {
            this.allOrders = allOrders;
            this.shopCart = shopCart;
        }

        public IActionResult Checkout()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            shopCart.listShopItems = shopCart.getShopItems();
            if (shopCart.listShopItems.Count == 0)
            {
                ModelState.AddModelError("","У вас должны быть товары");
            }
            if (ModelState.IsValid)
            {
                allOrders.createOrder(order);
                return RedirectToAction("Complete");
            }
            return View(order);

        }
        public IActionResult Complete()
        {
            ViewBag.Messege = "Заказ успешно обработан";
            return View();
        }
    }
}
