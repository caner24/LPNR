using PlatePass.Core.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatePass.Entities
{
    public class User : IEntity
    {
        public User()
        {
            Plates = new List<Plate>();
        }
        public int Id { get; set; }
        public string UserName { get; set; }
        public string UserSurname { get; set; }
        public string EmailAdres { get; set; }
        public List<Plate> Plates { get; set; }
    }
}
