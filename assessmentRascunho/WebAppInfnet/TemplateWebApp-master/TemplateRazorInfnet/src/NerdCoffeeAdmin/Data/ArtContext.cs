using MeuMiniMuseu.Data.Models;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;

namespace MeuMiniMuseu.Data
{
    public class ArtContext : DbContext
    {
        public ArtContext(DbContextOptions<ArtContext> options) : base(options)
        {

        }
        public DbSet<Models.Pintura> Pintura { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pintura>().HasData(
            new Pintura()
            {
                Id = 14,
                Nome = "Woman with Daisies",
                Artista = "Alfons Maria Mucha",
                Movimento = "Art Noveau",
                AnoCriacao = "1899",
                ImageFile = "alfons.jpg",

            },

             new Pintura()
             {
                 Id = 15,
                 Nome = "Death and the Soldier",
                 Artista = "Hans Larwin",
                 Movimento = "Academicismo",
                 AnoCriacao = "1917",
                 ImageFile = "death.jpg",
             },
              new Pintura()
              {
                  Id = 16,
                  Nome = "On the Seashore",
                  Artista = "Hanuš Knöchel",
                  Movimento = "Academicismo",
                  AnoCriacao = "1879",
                  ImageFile = "seashore.jpg",
              });


        }

    }
}