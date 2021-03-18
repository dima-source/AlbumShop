using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumShop.Data.Models
{
    public class Album
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Group { get; set; }
        public int CountTrack { get; set; }
        public string ShortDesc { get; set; }
        public string LongDesc { get; set; }
        public string IMG { get; set; }
        public int Price { get; set; }
        public bool IsFavorite { get; set; }
        public bool Available { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
