using ASP_IW5_2018.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_IW5_2018.Models.PhotoAlbum
{
    public class PhotoAlbum
    {
        public int PhotoId { get; set; }
        public Photo Photo { get; set; }
        public int AlbumId { get; set; }
        public Album Album { get; set; }
    }
}
