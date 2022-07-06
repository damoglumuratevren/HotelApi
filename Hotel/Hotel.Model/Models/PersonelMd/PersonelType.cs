using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Model.Models.PersonelMd
{
    [Table("PersonelTypes")]

    public class PersonelType:BaseEntity
    {
        [Required, StringLength(100), Display(Name = "Personel Tipi")]
        public string PersonelTypeName { get; set; }
    }
}
