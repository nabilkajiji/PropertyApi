using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace PropertyApi.Models
{
    public class Artist
    {
        public int Id { get; set; }
       
        
        
        [Required]
        public string Name { get; set; } = string.Empty;
        [JsonIgnore]

        public List<Painting>? Paintings { get; set; }
        

       
   
       
        
    }
}
