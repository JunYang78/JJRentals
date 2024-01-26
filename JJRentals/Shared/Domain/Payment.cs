using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JJRentals.Shared.Domain
{
    public class Payment : BaseDomainModel
    {
        [Required]
        [Column(TypeName = "decimal(10, 2)")]
        [Range(0.01, 1000000.00, ErrorMessage = "The amount must be between 0.01 and 1000000.00.")]
        public decimal Amount { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [PastDate(ErrorMessage = "The payment date cannot be in the future.")]
        public DateTime PaymentDate { get; set; }

        [Required]
        public string PaymentMethod { get; set; }

        [Required]
        public string PaymentStatus { get; set; }

        [Required]
        public int BookingID { get; set; }
        public virtual Booking? Booking { get; set; }
    }

    public class PastDateAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            return value is DateTime dateTime && dateTime <= DateTime.Today;
        }
    }
}
