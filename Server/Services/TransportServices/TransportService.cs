using AutoMapper;
using MASProject.Server.DAL.TransportRepositories;
using MASProject.Server.Models.TransportModels;
using MASProject.Shared.DTOs.TransportDTOs;

namespace MASProject.Server.Services.TransportServices
{
    /// <summary>
    /// Service class for transport operations.
    /// </summary>
    public class TransportService : ITransportService
    {
        private readonly ITransportRepository<Transport> _transportRepository;
        private readonly IMapper _mapper;
        /// <summary>
        /// Initializes a new instance of the <see cref="TransportService"/> class.
        /// </summary>
        /// <param name="transportRepository">The transport repository.</param>
        /// <param name="mapper">The mapper.</param>
        public TransportService(ITransportRepository<Transport> transportRepository, IMapper mapper)
        {
            _transportRepository = transportRepository;
            _mapper = mapper;
        }
        /// <inheritdoc />
        public async Task<List<TransportDTO>> GetTransportDTOsAsync()
        {
            var transports = await _transportRepository.GetTransportsAsync();
            return _mapper.Map<List<TransportDTO>>(transports);
        }
    }
}
