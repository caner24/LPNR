using PlatePass.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatePass.Entities
{
    public class Plate:IEntity
    {
        public int Id { get; set; }
        public string PlateText { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public List<PlateDetails> PlateDetails { get; set; }
    }
}
