using AlbumShop.Data.Interfaces;
using AlbumShop.Data.Models;
using AlbumShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumShop.Controllers
{
    public class StaffController : Controller
    {
        private readonly IAllStaff _allStaffs;


        public StaffController(IAllStaff iAllStaffs)
        {
            _allStaffs = iAllStaffs;

        }
        [Route("Staff/ListStaff")]
        

        public ViewResult List(string category)
        {

            IEnumerable<Staff> staffs;
            string currStaff = "";


            staffs = _allStaffs.Staffs;


            var albumObj = new StaffListViewModel
            {
                GetAllStaffs = staffs,
                currStaff = currStaff
            };
            ViewBag.Title = "Страница сотрудников";


            return View(albumObj);
        }
    }
}
