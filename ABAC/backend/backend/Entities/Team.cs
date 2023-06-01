using System.ComponentModel.DataAnnotations;

namespace backend.Entities
{
    public class Team
    {
        [Key]
        public int Id { get; set; }
        public Captain Captain { get; set; }
        public List<Robot> Robots { get; set; } = new List<Robot> { };
    }
}
