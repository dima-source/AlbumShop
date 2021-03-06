using AlbumShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumShop.Data.Interfaces
{
    public interface IAllStaff
    {
        IEnumerable<Staff> Staffs {get;set;}
        Staff GetObjStaff(int Id);
    }
}
