using ASP_IW5_2018.Infrastructure.Interface;
using System.Collections.Generic;

namespace ASP_IW5_2018.Models.PhotoAlbum
{
    public class Album : IModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public IList<PhotoAlbum> PhotoAlbums { get; set; }
    }
}
