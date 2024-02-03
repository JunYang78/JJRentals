using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JJRentals.Shared.Domain
{
    public class Staff : BaseDomainModel
    {
        [Required]
        [StringLength(100, ErrorMessage = "Name must be between 2 and 100 characters", MinimumLength = 2)]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(100, ErrorMessage = "Password must be strong and between 6 and 100 characters", MinimumLength = 6)]
        public string Password { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [Phone(ErrorMessage = "Invalid Phone Number")]
        [StringLength(8, ErrorMessage = "Contact number must be 8 digits")]
        public string ContactNo { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Required]
        [StringLength(200, ErrorMessage = "Address must be between 10 and 200 characters", MinimumLength = 10)]
        public string Address { get; set; }

        public DateTime HireDate { get; set; }

        [Required]
        [StringLength(200, ErrorMessage = "Position must be between 10 and 200 characters", MinimumLength = 10)]
        public string Position { get; set; }

        [Required]
        public int OutletId { get; set; }
        public virtual Outlet? Outlet { get; set; }
    }

   
}