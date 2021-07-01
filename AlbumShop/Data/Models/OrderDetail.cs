using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumShop.Data.Models
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int AlbumId { get; set; }
        public int Price { get; set; }
        
        public virtual Album Album { get; set; }
        public virtual Order Order { get; set; }
    }
}
