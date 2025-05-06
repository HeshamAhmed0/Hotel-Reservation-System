using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Hotel_Reservations.Models;
using Microsoft.EntityFrameworkCore;

namespace Hotel_Reservations.DbContexts
{
    internal class ApplicationDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server =.;database =Hotel;TrustServerCertificate=true;Trusted_Connection=true;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Reservation>().HasMany(T => T.Tourist)
                                              .WithOne(R => R.Reservation)
                                              .HasForeignKey(F => F.)
        }
        public DbSet<Tourist> Tourists { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Payment> Payment { get; set; }
    }
}
