using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace PropertyApi.Models
{
    public class Painting
    {
        public int Id { get; set; }
        [Required]
       
       
        public string Name { get; set; } = string.Empty;
        [Required]
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        

        [Required]
        public int ArtistId { get; set; }
        
        public Artist? Artist { get; set; }

    }
}
