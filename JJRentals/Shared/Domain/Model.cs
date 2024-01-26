using System;
using System.ComponentModel.DataAnnotations;

namespace JJRentals.Shared.Domain
{
    public class Model : BaseDomainModel
    {
        [Required]
        [StringLength(100, ErrorMessage = "The model name must be less than 100 characters long.")]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [PastDate(ErrorMessage = "The date created must be a past date.")]
        public DateTime DateCreated { get; set; }

        [Required]
        [Range(1, 9, ErrorMessage = "Seat capacity must be between 1 and 9.")]
        public int SeatCapacity { get; set; }

        [Required]
        public string FuelType { get; set; }

        [Required]
        public string TransmissionType { get; set; }

        [Required]
        public int ManufacturerId { get; set; }
        public virtual Manufacturer? Manufacturer { get; set; }
    }
}
