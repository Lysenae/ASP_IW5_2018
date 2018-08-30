using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ASP_IW5_2018.Infrastructure.Database;
using ASP_IW5_2018.Models.PhotoAlbum;

namespace ASP_IW5_2018.Controllers
{
    public class AlbumController : Controller
    {
        public ActionResult Index()
        {
            List<Album> albums = new List<Album>();
            using (PhotoAlbumDbContext ctx = new PhotoAlbumDbContext())
            {
                albums = ctx.Albums.ToList();
            }
            return View(albums);
        }
    }
}