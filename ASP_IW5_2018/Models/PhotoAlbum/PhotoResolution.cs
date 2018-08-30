using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP_IW5_2018.Models.Interfaces;

namespace ASP_IW5_2018.Models.PhotoAlbum
{
    public class PhotoResolution : IModel
    {
        public int Id { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public int PhotoId { get; set; }
        public Photo Photo { get; set; }
    }
}
