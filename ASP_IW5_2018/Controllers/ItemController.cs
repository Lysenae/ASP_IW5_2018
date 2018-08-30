using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ASP_IW5_2018.Infrastructure.Database;
using ASP_IW5_2018.Models.PhotoAlbum;

namespace ASP_IW5_2018.Controllers
{
    public class ItemController : Controller
    {
        public ActionResult Index()
        {
            List<Item> items = new List<Item>();
            using (PhotoAlbumDbContext ctx = new PhotoAlbumDbContext())
            {
                items = ctx.Items.ToList();
            }
            return View(items);
        }
    }
}