using ASP_IW5_2018.Models.PhotoAlbum;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_IW5_2018.ViewModels.PhotoAlbum
{
    public class PhotoViewModel
    {
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateTaken { get; set; }
        public string Format { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public string Note { get; set; }

        public PhotoViewModel()
        {
            DateTaken = DateTime.Now;
        }

        public static  PhotoViewModel FromPhoto(Photo photo)
        {
            if (photo != null)
            {
                return new PhotoViewModel()
                {
                    Id = photo.Id,
                    Name = photo.Name,
                    DateTaken = photo.DateTaken,
                    Format = photo.Format,
                    Note = photo.Note,
                    Width = photo.Resolution?.Width ?? 0,
                    Height = photo.Resolution?.Height ?? 0
                };
            }
            return null;
        }
    }
}
