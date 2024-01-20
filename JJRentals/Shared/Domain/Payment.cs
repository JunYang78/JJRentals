using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JJRentals.Shared.Domain
{
    public class Payment : BaseDomainModel
    {
        [Required]
        [Column(TypeName = "decimal(10, 2)")]
        public decimal Amount { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime PaymentDate { get; set; }
        [Required]
        public string PaymentMethod { get; set; }
        [Required]
        public string PaymentStatus { get; set; }
        [Required]
        public int BookingID { get; set; }
        public virtual Booking Booking { get; set; }
        
    }
}
