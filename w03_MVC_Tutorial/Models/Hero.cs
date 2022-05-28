using System.ComponentModel.DataAnnotations;

namespace w03_MVC_Tutorial.Models
{
    public class Hero
    {
        // 驗證屬性
        // Validation Attribute
        [Required]
        [Range(1, 1000)]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Range(0, 100)]
        public int Atk { get; set; }
        [Required]
        [Range(1, 100)]
        public int Hp { get; set; }
    }
}
