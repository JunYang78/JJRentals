using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JJRentals.Shared.Domain
{
    public class Payment : BaseDomainModel, IValidatableObject
    {
        [Required]
        public int? BookingID { get; set; }
        public virtual Booking? Booking { get; set; }
        [Required]
        [Range(1, 1000000, ErrorMessage = "Amount must be between 1 and 1,000,000")]
        public decimal? Amount { get; set; }
        [Required]
        [Range(0, 1000000, ErrorMessage = "Amount must be between 0 and 1,000,000")]
        public decimal? Deposit { get; set; }


        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            throw new NotImplementedException();
        }
    }
}
