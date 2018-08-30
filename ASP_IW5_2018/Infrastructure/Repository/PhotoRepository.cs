using ASP_IW5_2018.Infrastructure.Database;
using ASP_IW5_2018.Infrastructure.Interface;
using ASP_IW5_2018.Models.PhotoAlbum;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace ASP_IW5_2018.Infrastructure.Repository
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
                item.Resolution.Photo = item;
                item.Resolution.PhotoId = item.Id;
                ctx.Resolutions.Add(item.Resolution);
                ctx.SaveChanges();
            }
        }

        public void Add(IList<Photo> items)
        {
            using (PhotoAlbumDbContext ctx = new PhotoAlbumDbContext())
            {
                foreach (Photo p in items)
                {
                    ctx.Photos.Add(p);
                    p.Resolution.Photo = p;
                    p.Resolution.PhotoId = p.Id;
                    ctx.Resolutions.Add(p.Resolution);
                }
                ctx.SaveChanges();
            }
        }

        public Photo Get(int id)
        {
            if (id < 0)
                return null;

            using (PhotoAlbumDbContext ctx = new PhotoAlbumDbContext())
            {
                return ctx.Photos.Include(x => x.Resolution).ToList().Find(x => x.Id == id);
            }
        }

        public List<Photo> GetAll()
        {
            using (PhotoAlbumDbContext ctx = new PhotoAlbumDbContext())
            {
                return ctx.Photos.Include(x => x.Resolution).ToList();
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
