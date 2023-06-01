using backend.ViewModels;

namespace backend.Services.Interfaces
{
    public interface ICaptainService
    {
        Task<List<CaptainViewModel>> GetCaptains();
        Task<int> AddCaptainAsync(CaptainViewModel planet);
    }
}
