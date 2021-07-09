using AlbumShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumShop.ViewModels
{
    public class StaffListViewModel
    {
        public IEnumerable<Staff> GetAllStaffs { get; set; }
        public string currStaff { get; set; }
    }
}
