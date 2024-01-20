using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JJRentals.Shared.Domain
{
    public class Maintenance : BaseDomainModel
    {
        [Required]
        public DateTime SentDate { get; set; }

        public DateTime? ReturnDate { get; set; }

        public string ServiceProvider { get; set; }

        public string PartsAffected { get; set; }

        [Required]
        [Column(TypeName = "decimal(10, 2)")]
        public decimal Cost { get; set; }

        [Required]
        public int StaffId { get; set; }
        public virtual Staff Staff { get; set; }

        [Required]
        public int CarId { get; set; }
        public virtual Car Car { get; set; }
    }
}
