using ASP_IW5_2018.Infrastructure.Database;
using ASP_IW5_2018.Models.Interfaces;
using ASP_IW5_2018.Models.PhotoAlbum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_IW5_2018.Models.Repository
{
    public class PhotoRepository : IRepository<Photo>
    {
        public PhotoRepository()
        {
        }

        public void Add(Photo item)
        {
            using (PhotoAlbumDbContext ctx = new PhotoAlbumDbContext())
            {
                ctx.Photos.Add(item);
                ctx.SaveChanges();
            }
        }

        public void Add(IList<Photo> items)
        {
            using (PhotoAlbumDbContext ctx = new PhotoAlbumDbContext())
            {
                foreach (Photo p in items)
                    ctx.Photos.Add(p);
                ctx.SaveChanges();
            }
        }

        public Photo Get(int id)
        {
            if (id < 0)
                return null;

            using (PhotoAlbumDbContext ctx = new PhotoAlbumDbContext())
            {
                return ctx.Photos.Find(id);
            }
        }

        public List<Photo> GetAll()
        {
            using (PhotoAlbumDbContext ctx = new PhotoAlbumDbContext())
            {
                return ctx.Photos.ToList();
            }
        }

        public void Remove(Photo item)
        {
            if (item == null)
                return;

            using (PhotoAlbumDbContext ctx = new PhotoAlbumDbContext())
            {
                ctx.Photos.Remove(item);
                ctx.SaveChanges();
            }
        }

        public void Remove(IList<Photo> items)
        {
            using (PhotoAlbumDbContext ctx = new PhotoAlbumDbContext())
            {
                foreach (Photo p in items)
                    ctx.Photos.Remove(p);
                ctx.SaveChanges();
            }
        }
    }
}
