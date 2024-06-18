using AutoMapper;
using MASProject.Server.DAL.TransportRepositories;
using MASProject.Server.Models.TransportModels;
using MASProject.Shared.DTOs.UseCaseDTOs;

namespace MASProject.Server.Services.TransportServices
{
    public class TransportService : ITransportService
    {
        private readonly ITransportRepository<Transport> _transportRepository;
        private readonly IMapper _mapper;
        public TransportService(ITransportRepository<Transport> transportRepository, IMapper mapper)
        {
            _transportRepository = transportRepository;
            _mapper = mapper;
        }
        public async Task<List<TransportDTO>> GetTransportDTOsAsync()
        {
            var transports = await _transportRepository.GetTransportsAsync();
            return _mapper.Map<List<TransportDTO>>(transports);
        }
    }
}
