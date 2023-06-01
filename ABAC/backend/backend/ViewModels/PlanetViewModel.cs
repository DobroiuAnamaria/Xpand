using backend.Entities;

namespace backend.ViewModels
{
    public class PlanetViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public PlanetStatus PlanetStatus { get; set; }
        public int TeamId { get; set; }
        public TeamViewModel Team { get; set; }
    }
}
