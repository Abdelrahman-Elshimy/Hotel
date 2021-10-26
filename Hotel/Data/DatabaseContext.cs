using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel.Data
{
    public class DatabaseContext: DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {}
        public DbSet<Country> Countries { get; set; }
        public DbSet<Hotell> Hotels { get; set; }

        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    builder.Entity<Country>().HasData(
        //        new Country
        //        {
        //            Id = 1,
        //            Name = "Egypt",
        //            ShortName = "EG"
        //        },
        //         new Country
        //         {
        //             Id = 2,
        //             Name = "Qatar",
        //             ShortName = "Q"
        //         },
        //          new Country
        //          {
        //              Id = 3,
        //              Name = "Kuyait",
        //              ShortName = "KY"
        //          }
        //        );
        //    builder.Entity<Hotel>().HasData(
        //        new Hotel
        //        {
        //            Id = 1,
        //            Name = "Helton",
        //            Address = "Cairo",
        //            Rate = 4.5,
        //            CountryId = 1
        //        },
        //        new Hotel
        //        {
        //            Id = 2,
        //            Name = "Bahamas",
        //            Address = "Cairo",
        //            Rate = 4,
        //            CountryId = 3
        //        },
        //        new Hotel
        //        {
        //            Id = 3,
        //            Name = "ICon",
        //            Address = "Cairo",
        //            Rate = 5,
        //            CountryId = 2
        //        }
        //        );
        //}
    }

}
