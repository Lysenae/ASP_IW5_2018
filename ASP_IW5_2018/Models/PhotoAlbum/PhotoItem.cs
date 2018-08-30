using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_IW5_2018.Models.PhotoAlbum
{
    public class PhotoItem
    {
        public int PhotoId { get; set; }
        public Photo Photo { get; set; }
        public int ItemId { get; set; }
        public Item Item { get; set; }
    }
}
