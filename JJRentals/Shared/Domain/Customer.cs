using System.ComponentModel.DataAnnotations;

namespace JJRentals.Shared.Domain
{
	public class Customer : BaseDomainModel
	{
        [Required]
        public string Name { get; set; }
        [Required]
        public string Password { get; set; } 
        public string Address { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string ContactNo { get; set; }
        [Required]
        public string DriverLicenseNo { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime LicenseIssueDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime LicenseExpDate { get; set; }
    }
}