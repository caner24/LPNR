using Microsoft.EntityFrameworkCore;
using PlatePass.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatePass.DataAcess
{
    public class PlatePassContext : DbContext
    {
        public DbSet<Plate> Plate { get; set; }
        public DbSet<PlateUserDetail> PlateUserDetail { get; set; }
        public DbSet<User> User { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"");
            }
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PlateUserDetail>().HasKey(x => new { x.UserId, x.PlateId });
        }
    }
}
