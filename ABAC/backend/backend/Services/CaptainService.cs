using AutoMapper;
using backend.Entities;
using backend.Repositories.Interfaces;
using backend.Services.Interfaces;
using backend.ViewModels;

namespace backend.Services
{
    public class CaptainService : ICaptainService
    {
        private readonly ICaptainRepository _captainRepository;
        private readonly IMapper _mapper;


        public CaptainService(ICaptainRepository captainRepository, IMapper mapper)
        {
            _captainRepository = captainRepository;
            _mapper = mapper;
        }
        public async Task<int> AddCaptainAsync(CaptainViewModel captain)
        {
            return await _captainRepository.AddAsync(_mapper.Map<Captain>(captain));
        }

        public async Task<List<CaptainViewModel>> GetCaptains()
        {
            var captains = await _captainRepository.GetAllAsync();
            return _mapper.Map<List<CaptainViewModel>>(captains);
        }
    }
}
