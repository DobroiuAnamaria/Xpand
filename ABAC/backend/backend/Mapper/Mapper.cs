using AutoMapper;
using backend.Entities;
using backend.ViewModels;

namespace backend.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Planet, PlanetViewModel>();
            CreateMap<PlanetViewModel, Planet>();
            CreateMap<UpdatePlanetViewModel, Planet>();
            CreateMap<Planet, UpdatePlanetViewModel>();

            CreateMap<Robot, RobotViewModel>();
            CreateMap<RobotViewModel, Robot>();

            CreateMap<Captain, CaptainViewModel>();
            CreateMap<CaptainViewModel, Captain>();

            CreateMap<Team, TeamViewModel>();
            CreateMap<TeamViewModel, Team>();
        }
    }
}
