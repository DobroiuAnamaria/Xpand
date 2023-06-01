using System.ComponentModel.DataAnnotations;

namespace backend.Entities
{
    public class Robot
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int TeamId { get; set; }
        public Team Team { get; set; }
    }
}
