using Microsoft.EntityFrameworkCore;

namespace PropertyApi.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Artist>().HasData(
            new Artist { Id = 1, Name = "nabeel " },
            new Artist { Id = 2, Name = "bash " },
            new Artist { Id = 3, Name = "tjay " },
            new Artist { Id = 4, Name = "wizdom " },
            new Artist { Id = 5, Name = "usman " }
        );
            modelBuilder.Entity<Painting>().HasData(
            new Painting { Id = 1, Name = "Starry Night", Description = "A famous painting by Vincent van Gogh.", Price = 1000.00m, ArtistId = 1 },
            new Painting { Id = 2, Name = "Mona Lisa", Description = "A portrait painting by Leonardo da Vinci.", Price = 2000.00m, ArtistId = 2 },
            new Painting { Id = 3, Name = "The Persistence of Memory", Description = "A surreal painting by Salvador Dalí.", Price = 1500.00m, ArtistId = 3 },
            new Painting { Id = 4, Name = "The Scream", Description = "An iconic piece by Edvard Munch.", Price = 1200.00m, ArtistId = 4 },
            new Painting { Id = 5, Name = "Girl with a Pearl Earring", Description = "A well-known painting by Johannes Vermeer.", Price = 1300.00m, ArtistId = 5 },
            new Painting { Id = 6, Name = "The Night Watch", Description = "A famous painting by Rembrandt.", Price = 1600.00m, ArtistId = 1 },
            new Painting { Id = 7, Name = "Guernica", Description = "A powerful piece by Pablo Picasso.", Price = 1800.00m, ArtistId = 2 },
            new Painting { Id = 8, Name = "The Birth of Venus", Description = "A renowned painting by Sandro Botticelli.", Price = 1700.00m, ArtistId = 3 },
            new Painting { Id = 9, Name = "American Gothic", Description = "A notable painting by Grant Wood.", Price = 1100.00m, ArtistId = 4 },
            new Painting { Id = 10, Name = "The Kiss", Description = "A beautiful painting by Gustav Klimt.", Price = 1400.00m, ArtistId = 5 },
            new Painting { Id = 11, Name = "The Creation of Adam", Description = "A famous fresco by Michelangelo.", Price = 1900.00m, ArtistId = 1 },
            new Painting { Id = 12, Name = "Water Lilies", Description = "A series by Claude Monet.", Price = 2100.00m, ArtistId = 2 }
        );

        }
    }
}
