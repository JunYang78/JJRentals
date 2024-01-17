﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace JJRentals.Shared.Domain
{
	public class Booking : BaseDomainModel, IValidatableObject
	{
		[Required]
        [DataType(DataType.Date)]
        public DateTime DateOut { get; set; }
		public DateTime? DateIn { get; set; }
        [Required]
        public int? CarId { get; set; }
		public virtual Car? Car { get; set; }
        [Required]
        public int? CustomerId { get; set; }
		public virtual Customer? Customer { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            //throw new NotImplementedException();

			if (DateIn != null)
			{
				if (DateIn <= DateOut)
				{
					yield return new ValidationResult("DateIn must be greater than DateOut", new[] { "DateIn" });
				}
			}
        }
    }
}