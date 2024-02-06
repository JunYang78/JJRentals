using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace JJRentals.Shared.Domain
{
    public class Manufacturer : BaseDomainModel
    {
        [Required]
        [StringLength(100, ErrorMessage = "The name must be less than 100 characters long.")]
        public string Name { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "The email address is not in a valid format.")]
        public string Email { get; set; }

        [Required]
        [Phone(ErrorMessage = "The contact number is not in a valid format.")]
        [StringLength(8, ErrorMessage = "Contact number must be 8 digits")]
        public string ContactNo { get; set; }
    }
}
