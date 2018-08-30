using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP_IW5_2018.Models.Interfaces;

namespace ASP_IW5_2018.Models.PhotoAlbum
{
    public class Photo : IModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateTaken { get; set; }
        public string Format { get; set; }
        public PhotoResolution Resolution { get; set; }
        public string Note { get; set; }

        public IList<PhotoAlbum> PhotoAlbums { get; set; }
        public IList<PhotoItem> PhotoItems { get; set; }
        public IList<PhotoPerson> PhotoPersons { get; set; }
    }
}
