using ASP_IW5_2018.Models.Interfaces;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASP_IW5_2018.Models.PhotoAlbum
{
    public class Person : IModel, IPhotoObject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public IList<PhotoPerson> PhotoPersons { get; set; }

        [NotMapped]
        public string FullName { get { return $"{Name} {Surname}"; } }
    }
}
