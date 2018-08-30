using ASP_IW5_2018.Infrastructure.Interface;

namespace ASP_IW5_2018.Models.PhotoAlbum
{
    public class PhotoResolution : IModel
    {
        public int Id { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public int PhotoId { get; set; }
        public Photo Photo { get; set; }

        public override string ToString()
        {
            return $"{Width}x{Height}";
        }
    }
}
