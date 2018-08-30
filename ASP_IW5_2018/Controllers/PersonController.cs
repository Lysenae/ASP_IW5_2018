using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ASP_IW5_2018.Infrastructure.Database;
using ASP_IW5_2018.Models.PhotoAlbum;

namespace ASP_IW5_2018.Controllers
{
    public class PersonController : Controller
    {
        public ActionResult Index()
        {
            List<Person> people = new List<Person>();
            using (PhotoAlbumDbContext ctx = new PhotoAlbumDbContext())
            {
                people = ctx.People.ToList();
            }
            return View(people);
        }
    }
}