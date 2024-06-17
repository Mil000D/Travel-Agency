using MASProject.Server.DAL.BookingRepositories;
using MASProject.Server.DAL.LodgingRepositories;
using MASProject.Server.DAL.TourPurchaseRepositories;
using MASProject.Server.DAL.TourRepositories;
using MASProject.Server.Models.LodgingModels;
using MASProject.Server.Models.TransportModels;
using MASProject.Server.Services.TourServices;

namespace MASProject.Server.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<ITourRepository, TourRepository>();
            services.AddScoped<ITourPurchaseRepository, TourPurchaseRepository>();
            services.AddScoped<ILodgingRepository, LodgingRepository>();
            services.AddScoped<IBookingRepository<TransportBooking>, TransportBookingRepository>();
            services.AddScoped<IBookingRepository<LodgingBooking>, LodgingBookingRepository>();

            return services;
        }

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<ITourService, TourService>();

            return services;
        }
    }
}
