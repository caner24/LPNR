using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
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
        public DbSet<PlateDetails> PlateUserDetail { get; set; }
        public DbSet<User> User { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=CANER;Database=PlatePassDb;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True");
            }
            base.OnConfiguring(optionsBuilder);
        }
    }
}
