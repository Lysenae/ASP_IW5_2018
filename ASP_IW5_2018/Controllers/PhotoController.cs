using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ASP_IW5_2018.Models.PhotoAlbum;
using ASP_IW5_2018.Infrastructure.Repository;
using System.Diagnostics;
using ASP_IW5_2018.ViewModels.PhotoAlbum;

namespace ASP_IW5_2018.Controllers
{
    public class PhotoController : Controller
    {
        public PhotoRepository Photos { get; private set; }

        public PhotoController()
        {
            Photos = new PhotoRepository();
        }

        public ViewResult Index()
        {
            List<Photo> photos = Photos.GetAll();
            return View(photos);
        }

        public ViewResult Create()
        {
            return View(new PhotoViewModel());
        }

        [HttpPost]
        public ActionResult New(PhotoViewModel photo)
        {
            Photo p = new Photo()
            {
                Name = photo.Name,
                Format = photo.Format,
                Note = photo.Note,
                Resolution = new PhotoResolution()
                {
                    Width = photo.Width,
                    Height = photo.Height
                }
            };
            Photos.Add(p);
            return View("Details", photo);
        }

        public ViewResult Details(int id)
        {
            return View(PhotoViewModel.FromPhoto(Photos.Get(id)));
        }
    }
}