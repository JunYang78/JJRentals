using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Collections;

namespace JJRentals.Shared.Domain
{
	public class Booking : BaseDomainModel, IValidatableObject
	{
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime DateTime { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime RentalStartDate { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime RentalEndDate { get; set; }

        [Required]
        public string Location { get; set; }

        [Required]
        public string PickUpOption { get; set; }

        [Required]
        public int StaffId { get; set; }
        public virtual Staff? Staff { get; set; }

        [Required]
        public int CustomerId { get; set; }
        public virtual Customer? Customer { get; set; }

        [Required]
        public int CarId { get; set; }
        public virtual Car? Car { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            //throw new NotImplementedException();

			if (RentalStartDate != null)
			{
				if (RentalEndDate < RentalStartDate)
				{
					yield return new ValidationResult("End date must be greater than Start date", new[] { "RentalEndDate" });
				}
			}
        }
    }
}
