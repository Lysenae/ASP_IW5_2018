using Microsoft.EntityFrameworkCore;
using ASP_IW5_2018.Models.PhotoAlbum;
using Microsoft.Extensions.Configuration;
using System.IO;
using ASP_IW5_2018.ViewModels.PhotoAlbum;

namespace ASP_IW5_2018.Infrastructure.Database
{
    public class PhotoAlbumDbContext : DbContext
    {
        public PhotoAlbumDbContext()
        {
        }

        public PhotoAlbumDbContext(DbContextOptions<PhotoAlbumDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                   .SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("appsettings.json")
                   .Build();
                var connectionString = configuration.GetConnectionString("PhotoAlbumDb");
                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Photo>()
                .HasOne<PhotoResolution>(p => p.Resolution)
                .WithOne(pr => pr.Photo)
                .HasForeignKey<PhotoResolution>(pr => pr.PhotoId);
            modelBuilder.Entity<PhotoAlbum>().HasKey(pa => new { pa.PhotoId, pa.AlbumId });
            modelBuilder.Entity<PhotoPerson>().HasKey(pp => new { pp.PhotoId, pp.PersonId });
            modelBuilder.Entity<PhotoItem>().HasKey(pi => new { pi.PhotoId, pi.ItemId });
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Photo> Photos { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<PhotoAlbum> PhotoAlbums { get; set; }
        public DbSet<PhotoItem> PhotoItems { get; set; }
        public DbSet<PhotoPerson> PhotoPersons { get; set; }
        public DbSet<PhotoResolution> Resolutions { get; set; }
    }
}
