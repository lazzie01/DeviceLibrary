using Microsoft.EntityFrameworkCore;

namespace DeviceLibrary.DataAccessLayer.Models
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Camera> Cameras { get; set; }

        public DbSet<Laptop> Laptops { get; set; }

        public DbSet<Booking> Bookings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            SeedTypes(modelBuilder);
        }

        private static void SeedTypes(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Camera>()
                .HasData(new Camera
                {
                    Id = 1,
                    Name = "Canon",
                    Model = "CX101",
                    Available = true,
                    DeviceType = DeviceType.Camera
                });

            modelBuilder.Entity<Camera>()
                .HasData(new Camera
                {
                    Id = 2,
                    Name = "Philips",
                    Model = "PH001",
                    Available = true,
                    DeviceType = DeviceType.Camera
                });

            modelBuilder.Entity<Camera>()
                .HasData(new Camera
                {
                    Id = 3,
                    Name = "Sony",
                    Model = "SO09",
                    Available = true,
                    DeviceType = DeviceType.Camera
                });

            modelBuilder.Entity<Laptop>()
                .HasData(new Laptop
                {
                    Id = 1,
                    Name = "HP",
                    Model = "H01",
                    Available = true,
                    DeviceType = DeviceType.Laptop
                });

            modelBuilder.Entity<Laptop>()
                .HasData(new Laptop
                {
                    Id = 2,
                    Name = "DELL",
                    Model = "D123",
                    Available = true,
                    DeviceType = DeviceType.Laptop
                });

            modelBuilder.Entity<Laptop>()
                .HasData(new Laptop
                {
                    Id = 3,
                    Name = "Samsung",
                    Model = "S001",
                    Available = true,
                    DeviceType = DeviceType.Laptop
                });
        }
    }
}
