using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JJRentals.Shared.Domain
{
    public class Customer : BaseDomainModel
    {
        [Required]
        [StringLength(100, ErrorMessage = "Name must be between 2 and 100 characters", MinimumLength = 2)]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(100, ErrorMessage = "Password must be strong and between 6 and 100 characters", MinimumLength = 6)]
        public string Password { get; set; }

        [Required]
        [StringLength(200, ErrorMessage = "Address must be between 10 and 200 characters", MinimumLength = 10)]
        public string Address { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [CustomAgeValidation(18, ErrorMessage = "Customer must be at least 18 years old")]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Required]
        [Phone(ErrorMessage = "Invalid Phone Number")]
        [StringLength(8, ErrorMessage = "Contact number must be 8 digits")]
        public string ContactNo { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "Driver's license number must be between 5 and 20 characters", MinimumLength = 5)]
        public string DriverLicenseNo { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime LicenseIssueDate { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime LicenseExpDate { get; set; }
    }

    public class CustomAgeValidation : ValidationAttribute
    {
        private readonly int _minimumAge;

        public CustomAgeValidation(int minimumAge)
        {
            _minimumAge = minimumAge;
        }

        public override bool IsValid(object value)
        {
            DateTime date;
            if (DateTime.TryParse(value.ToString(), out date))
            {
                return date.AddYears(_minimumAge) < DateTime.Now;
            }
            return false;
        }
    }
}
