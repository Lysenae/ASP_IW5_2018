using ASP_IW5_2018.Infrastructure.Interface;

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
