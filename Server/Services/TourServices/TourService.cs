using AutoMapper;
using MASProject.Shared.DTOs.TourDTOs;
using MASProject.Server.DAL.TourRepositories;
using MASProject.Server.Models.TourModels;
using System.Globalization;

namespace MASProject.Server.Services.TourServices
{
    /// <summary>
    /// Service class for tour operations.
    /// </summary>
    public class TourService : ITourService
    {
        private readonly IMapper _mapper;
        private readonly ITourRepository _tourRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="TourService"/> class.
        /// </summary>
        /// <param name="tourRepository">The tour repository.</param>
        /// <param name="mapper">The mapper.</param>
        public TourService(ITourRepository tourRepository, IMapper mapper)
        {
            _tourRepository = tourRepository;
            _mapper = mapper;
        }

        /// <inheritdoc />
        public async Task DeleteTourAsync(int id)
        {
            await _tourRepository.DeleteTourAsync(id);
        }

        /// <inheritdoc />
        public async Task<GetTourDTO?> GetTourDTOAsync(int id)
        {
            var tour = await _tourRepository.GetTourAsync(id);
            return _mapper.Map<GetTourDTO?>(tour);
        }

        /// <inheritdoc />
        public async Task<GetAllToursDTO> GetTourDTOsAndToursCountAsync(int pageNumber, int pageSize, string? search = null, string? startDate = null, string? endDate = null)
        {
            DateTime? startDateTime = null;
            DateTime? endDateTime = null;
            if (startDate != null && endDate != null)
            {
                startDateTime = DateTime.ParseExact(startDate, "yyyy-MM-dd", CultureInfo.InvariantCulture);
                endDateTime = DateTime.ParseExact(endDate, "yyyy-MM-dd", CultureInfo.InvariantCulture);
            }
            (List<Tour> tours, int count) = await _tourRepository.GetToursAndToursCountAsync(pageNumber, pageSize, search, startDateTime, endDateTime);
            return new GetAllToursDTO
            {
                Tours = _mapper.Map<List<GetTourDTO>>(tours),
                ToursCount = count
            };
        }

        /// <inheritdoc />
        public async Task<UpdateTourDTO> GetUpdateTourDTOAsync(int id)
        {
            var tour = await _tourRepository.GetTourAsync(id);
            if (tour == null)
            {
                throw new KeyNotFoundException("Tour not found");
            }
            return _mapper.Map<UpdateTourDTO>(tour);
        }

        /// <inheritdoc />
        public async Task UpdateTourAsync(UpdateTourDTO tour)
        {
            var tourModel = await _tourRepository.GetTourAsync(tour.Id);
            if (tourModel == null)
            {
                throw new KeyNotFoundException("Tour not found");
            }
            _mapper.Map(tour, tourModel);
            await _tourRepository.UpdateTourAsync(tourModel);
        }
    }
}