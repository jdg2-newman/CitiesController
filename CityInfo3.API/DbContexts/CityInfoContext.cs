using System;
using CityInfo3.API.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace CityInfo3.API.DbContexts
{
    public class CityInfoContext: DbContext
    {

        public DbSet<City> Cities { get; set; }

        public DbSet<PointOfInterest> PointsOfInterest { get; set; } = null!;

        public CityInfoContext(DbContextOptions<CityInfoContext> options ):base(options)
        {

        }


        //protected override void OnConfiguring(DbContextOptionsBuilder  optionsBuilder)
        //{
        //    optionsBuilder.UseSqlite("connectionString");
        //    base.OnConfiguring(optionsBuilder);
        //}
        
    }
}

