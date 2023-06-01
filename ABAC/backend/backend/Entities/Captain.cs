using System.ComponentModel.DataAnnotations;

namespace backend.Entities
{
    public class Captain
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int TeamId { get; set; }
        public Team Team { get; set; }
    }
}
