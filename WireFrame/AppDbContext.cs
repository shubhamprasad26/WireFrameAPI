using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WireFrame.Model;
using WireFrames.Model;

namespace WireFrames
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Airlines> airliness { get; set; }
        public DbSet<FlightInfo> flightInfos { get; set; }
        public DbSet<Meals> mealss { get; set; }
        public DbSet<Places> placess { get; set; }
        public DbSet<ScheduleType> scheduleTypess { get; set; }
        public DbSet<Registration> registrations { get; set; }
        public DbSet<userFlights> userflights  { get; set; }
        public DbSet<BookFlight> bookFlights { get; set; }
        //public int MyProperty { get; set; }
        public DbSet<Discount> discounts { get; set; }
        //public DbSet<TCost> tCosts { get; set; }
    }
}
