using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Model.Models
{
    public  class BaseEntity
    {
        [Key]
        [StringLength(36)]
        public string Id { get; set; }

        public bool IsActive { get; set; } = true;

        [StringLength(36)]
        public string CreatedId { get; set; }

        public DateTime CreatedDtm { get; set; }

        [StringLength(36)]
        public string? UpdatedId { get; set; }

        public DateTime? UpdatedDtm { get; set; }
    }
}
