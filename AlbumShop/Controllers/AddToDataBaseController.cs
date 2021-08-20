using AlbumShop.Data;
using AlbumShop.Data.Models;
using AlbumShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumShop.Controllers
{
    public class AddToDataBaseController : Controller
    {
		ApplicationContext dBContext;
		ShopCart shopCart;
		public AddToDataBaseController(ApplicationContext dBContext, ShopCart shopCart)
		{
			this.dBContext = dBContext;
			this.shopCart = shopCart;
		}

		[HttpGet]
		public ActionResult Index()
		{
			var categories = new AddToDataBaseViewModel();
			categories.Categories = dBContext.Category;
			//ViewBag.ProductCount = shopCart.ProductCount();
			return View(categories);
		}

		[HttpGet]
		public ActionResult Categories()
		{
		//	ViewBag.ProductCount = shopCart.ProductCount();
			return View();
		}

		[HttpPost]
		public RedirectToActionResult Index(Album album)
		{
            //if (album.Category.CategoryName == "Рок")
            //{

            //}
            //else
            //{

            //}
			var category = dBContext.Category.FirstOrDefault(cat => cat.CategoryName.Equals("Рок"));
			album.CategoryId = category.Id;
			album.Category = category;
			dBContext.Album.Add(album);
			dBContext.SaveChanges();

			return RedirectToAction("Index", "Home");
		}

		[HttpPost]
		public RedirectToActionResult Categories(Category category)
		{
			dBContext.Category.Add(category);
			dBContext.SaveChanges();

			return RedirectToAction("Index", "Home");
		}
	}
}
