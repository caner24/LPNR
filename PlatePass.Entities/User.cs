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
        public int Id { get; set; }
        [Required(ErrorMessage = "İsmi bos birakmayin")]
        public int UserName { get; set; }
        [Required(ErrorMessage = "Soyismi bos birakmayin")]
        public int UserSurname { get; set; }

        [Required(ErrorMessage = "Email alanini boş birakmayin")]
        [EmailAddress(ErrorMessage = "Email adresi şeklinde girilmelidir")]
        public string EmailAdres { get; set; }

        [Required(ErrorMessage = "Email alanini boş birakmayin")]
        public string Number { get; set; }

        public List<Plate> Plates { get; set; }

        public List<PlateUserDetail> PlateUserDetails { get; set; }
    }
}
