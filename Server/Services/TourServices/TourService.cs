using AutoMapper;
using MASProject.Shared.DTOs.TourDTOs;
using MASProject.Server.DAL.TourRepositories;
using MASProject.Shared.DTOs.UseCaseDTOs;

namespace MASProject.Server.Services.TourServices
{
    public class TourService : ITourService
    {
        private readonly IMapper _mapper;
        private readonly ITourRepository _tourRepository;
        public TourService(ITourRepository tourRepository, IMapper mapper)
        {
            _tourRepository = tourRepository;
            _mapper = mapper;
        }

        public async Task DeleteTourAsync(int id)
        {
            await _tourRepository.DeleteTourAsync(id);
        }

        public Task<GetTourDTO?> GetTourAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<GetTourDTO>> GetToursAsync(int pageNumber, int pageSize)
        {
            var tours = await _tourRepository.GetToursAsync(pageNumber, pageSize);
            return _mapper.Map<List<GetTourDTO>>(tours);
        }
        public async Task<int> GetToursCountAsync()
        {
            return await _tourRepository.GetToursCountAsync();
        }

        public async Task<UpdateTourDTO> GetUpdateTourAsync(int id)
        {
            var tour = await _tourRepository.GetTourAsync(id);
            if (tour == null)
            {
                throw new KeyNotFoundException("Tour not found");
            }
            return _mapper.Map<UpdateTourDTO>(tour);
        }
    }
}