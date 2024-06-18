using MASProject.Server.DAL.BookingRepositories;
using MASProject.Server.DAL.LodgingRepositories;
using MASProject.Server.DAL.TourPurchaseRepositories;
using MASProject.Server.DAL.TourRepositories;
using MASProject.Server.DAL.TransportRepositories;
using MASProject.Server.DAL.UserRepositories;
using MASProject.Server.Models.LodgingModels;
using MASProject.Server.Models.TransportModels;
using MASProject.Server.Models.UserModels;
using MASProject.Server.Services.LodgingServices;
using MASProject.Server.Services.TourServices;
using MASProject.Server.Services.TransportServices;

namespace MASProject.Server.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<ITourRepository, TourRepository>();
            services.AddScoped<ITourPurchaseRepository, TourPurchaseRepository>();
            services.AddScoped<ILodgingRepository, LodgingRepository>();
            services.AddScoped<ITransportRepository<Plane>, TransportRepository<Plane>>();
            services.AddScoped<ITransportRepository<Train>, TransportRepository<Train>>();
            services.AddScoped<ITransportRepository<Transport>, TransportRepository<Transport>>();
            services.AddScoped<IBookingRepository<TransportBooking>, TransportBookingRepository>();
            services.AddScoped<IBookingRepository<LodgingBooking>, LodgingBookingRepository>();
            services.AddScoped<IUserRepository<Customer>, CustomerRepository>();
            services.AddScoped<IUserRepository<Admin>, AdminRepository>();
            return services;
        }

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<ITourService, TourService>();
            services.AddScoped<ILodgingService, LodgingService>();
            services.AddScoped<ITransportService, TransportService>();
            return services;
        }
    }
}
