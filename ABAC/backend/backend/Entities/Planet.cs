using System.ComponentModel.DataAnnotations;

namespace backend.Entities
{
    public class Planet
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; } = String.Empty;
        public string Image { get; set; }
        public PlanetStatus PlanetStatus { get; set; } = PlanetStatus.TODO;
        public int TeamId { get; set; }
        public Team Team { get; set; }
    }
}
