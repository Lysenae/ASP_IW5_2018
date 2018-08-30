using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ASP_IW5_2018.Infrastructure.Database;
using ASP_IW5_2018.Models.PhotoAlbum;

namespace ASP_IW5_2018.Controllers
{
    public class PhotoController : Controller
    {
        public ActionResult Index()
        {
            List<Photo> photos = new List<Photo>();
            using (PhotoAlbumDbContext ctx = new PhotoAlbumDbContext())
            {
                photos = ctx.Photos.ToList();
            }
            return View(photos);
        }
    }
}