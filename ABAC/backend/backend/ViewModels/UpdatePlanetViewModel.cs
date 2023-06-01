using backend.Entities;

namespace backend.ViewModels
{
    public class UpdatePlanetViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int TeamId { get; set; }
        public PlanetStatus PlanetStatus { get; set; }
    }
}
