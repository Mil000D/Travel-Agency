using AutoMapper;
using MASProject.Server.DAL.LodgingRepositories;
using MASProject.Shared.DTOs.UseCaseDTOs;

namespace MASProject.Server.Services.LodgingServices
{
    public class LodgingService : ILodgingService
    {
        private readonly ILodgingRepository _lodgingRepository;
        private readonly IMapper _mapper;
        public LodgingService(ILodgingRepository lodgingRepository, IMapper mapper)
        {
            _lodgingRepository = lodgingRepository;
            _mapper = mapper;
        }
        public async Task<List<LodgingDTO>> GetLodgingsAsync()
        {
            var lodgings = await _lodgingRepository.GetLodgingsAsync();
            return _mapper.Map<List<LodgingDTO>>(lodgings);
        }
    }
}
