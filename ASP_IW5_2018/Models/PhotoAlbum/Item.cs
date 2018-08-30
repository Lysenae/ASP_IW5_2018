using ASP_IW5_2018.Infrastructure.Interface;
using System.Collections.Generic;

namespace ASP_IW5_2018.Models.PhotoAlbum
{
    public class Item : IModel, IPhotoObject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public IList<PhotoItem> PhotoItems { get; set; }
    }
}
