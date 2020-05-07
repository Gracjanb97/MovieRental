namespace DatabaseAccess.Model
{
    using DatabaseAccess.Entities;
    using DatabaseAccess.EntitiesConfiguration;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class MovieRentalModel : DbContext
    {
        public MovieRentalModel()
            : base(nameOrConnectionString: "MovieRentalModel")
        {
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Account> Accounts { get; set; }

        public DbSet<Video> Videos { get; set; }

        public DbSet<VideoRental> VideoRentals { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserConfiguration());
            modelBuilder.Configurations.Add(new AccountConfiguration());
            modelBuilder.Configurations.Add(new VideoConfiguration());
            modelBuilder.Configurations.Add(new VideoRentalConfiguration());
            base.OnModelCreating(modelBuilder); 
        }
    }
}