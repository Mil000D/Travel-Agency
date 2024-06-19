using AutoMapper;
using MASProject.Server.DAL.LodgingRepositories;
using MASProject.Shared.DTOs.LodgingDTOs;

namespace MASProject.Server.Services.LodgingServices
{
    /// <summary>
    /// Service class for lodging operations.
    /// </summary>
    public class LodgingService : ILodgingService
    {
        private readonly ILodgingRepository _lodgingRepository;
        private readonly IMapper _mapper;
        
        /// <summary>
        /// Initializes a new instance of the <see cref="LodgingService"/> class.
        /// </summary>
        /// <param name="lodgingRepository">The lodging repository.</param>
        /// <param name="mapper">The mapper.</param>
        public LodgingService(ILodgingRepository lodgingRepository, IMapper mapper)
        {
            _lodgingRepository = lodgingRepository;
            _mapper = mapper;
        }

        /// <inheritdoc />
        public async Task<List<LodgingDTO>> GetLodgingDTOsAsync()
        {
            var lodgings = await _lodgingRepository.GetLodgingsAsync();
            return _mapper.Map<List<LodgingDTO>>(lodgings);
        }
    }
}
