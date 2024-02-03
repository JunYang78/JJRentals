using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JJRentals.Shared.Domain
{
    public class Outlet : BaseDomainModel
    {
        [Required]
        [StringLength(100, ErrorMessage = "The outlet name must be less than 100 characters long.")]
        public string Name { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The Location name must be less than 100 characters long.")]
        public string Location { get; set; }

        [Required]
        [Phone(ErrorMessage = "Invalid Phone Number")]
        [StringLength(8, ErrorMessage = "Contact number must be 8 digits")]
        public string ContactNo { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }
    }
}