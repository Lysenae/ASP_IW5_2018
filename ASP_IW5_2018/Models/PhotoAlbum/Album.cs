using ASP_IW5_2018.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_IW5_2018.Models.PhotoAlbum
{
    public class Album : IModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public IList<PhotoAlbum> PhotoAlbums { get; set; }
    }
}
