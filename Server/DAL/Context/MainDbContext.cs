using MASProject.Server.Models.LodgingModels;
using MASProject.Server.Models.SharedModels;
using MASProject.Server.Models.TourModels;
using MASProject.Server.Models.TransportModels;
using MASProject.Server.Models.UserModels;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace MASProject.Server.DAL.Context
{
    public class MainDbContext : DbContext
    {
        public MainDbContext(DbContextOptions<MainDbContext> options) : base(options)
        {
        }
        protected MainDbContext()
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<LodgingBooking> LodgingBookings { get; set; }
        public DbSet<TransportBooking> TransportBookings { get; set; }
        public DbSet<Tour> Tours { get; set; }
        public DbSet<TourPurchase> TourPurchases { get; set; }
        public DbSet<Transport> Transports { get; set; }
        public DbSet<Lodging> Lodgings { get; set; }
        public DbSet<Plane> Planes { get; set; }
        public DbSet<Train> Trains { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<Booking>();
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MainDbContext).Assembly);
        }

        public override int SaveChanges()
        {
            var entities = ChangeTracker.Entries()
                                         .Where(e => e.State == EntityState.Added || e.State == EntityState.Modified)
                                         .Select(e => e.Entity);

            foreach (var entity in entities)
            {
                var validationContext = new ValidationContext(entity);
                Validator.ValidateObject(
                    entity,
                    validationContext,
                    validateAllProperties: true);
            }

            return base.SaveChanges();
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var entities = ChangeTracker.Entries()
                                         .Where(e => e.State == EntityState.Added || e.State == EntityState.Modified)
                                         .Select(e => e.Entity);

            foreach (var entity in entities)
            {
                var validationContext = new ValidationContext(entity);
                Validator.ValidateObject(
                    entity,
                    validationContext,
                    validateAllProperties: true);
            }

            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
