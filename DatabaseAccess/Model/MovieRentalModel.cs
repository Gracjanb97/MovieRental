namespace DatabaseAccess.Model
{
    using DatabaseAccess.Entities;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class MovieRentalModel : DbContext
    {
        public MovieRentalModel()
            : base(nameOrConnectionString: "Default")
        {
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Account> Accounts { get; set; }

        public DbSet<Video> Videos { get; set; }

        public DbSet<VideoRental> VideoRentals { get; set; }

    }
}