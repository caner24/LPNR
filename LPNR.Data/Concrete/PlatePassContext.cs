using LPNR.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPNR.Data.Concrete
{
    public class PlatePassContext:DbContext
    {
        public DbSet<User> User { get; set; }
        public DbSet<Plate> Plate { get; set; }

    }
}
