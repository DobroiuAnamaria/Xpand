namespace backend.ViewModels
{
    public class TeamViewModel
    {
        public int Id { get; set; }
        public CaptainViewModel Captain { get; set; }
        public List<RobotViewModel> Robots { get; set; }

    }
}
