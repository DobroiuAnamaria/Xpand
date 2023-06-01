using backend.ViewModels;

namespace backend.Services.Interfaces
{
    public interface IRobotService
    {
        Task<List<RobotViewModel>> GetRobots();
        Task<int> AddRobotAsync(RobotViewModel robot);
    }
}
