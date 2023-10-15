using LPNR.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPNR.Entities
{
    public class Plate:IEntity
    {
        public int Id { get; set; }
        public string PlateNumber { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
