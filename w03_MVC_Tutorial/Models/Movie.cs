using System.ComponentModel.DataAnnotations;

namespace w03_MVC_Tutorial.Models
{
    public class Movie
    {
        [Required]
        [Range(1, 1000)]
        public int Id { get; set; }
        [Required]
        public string MName { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        [Range(1, 240)]
        public int Duration { get; set; }
            
    }
}