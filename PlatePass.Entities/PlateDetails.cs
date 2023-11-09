using PlatePass.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatePass.Entities
{
    public class PlateDetails : IEntity
    {
        public int Id { get; set; }
        public int PlateId { get; set; }
        public Plate Plate { get; set; }
        public DateTime PassDate { get; set; }
        public bool IsSafePlate { get; set; }
    }
}
