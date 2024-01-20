using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JJRentals.Shared.Domain
{
	public class Model : BaseDomainModel
	{
        [Required]
        public string Name { get; set; }
        [Required]
        public DateTime DateCreated { get; set; }
        [Required]
        public int SeatCapacity { get; set; }
        [Required]
        public string FuelType { get; set; }
        [Required]
        public string TransmissionType { get; set; }
        [Required]
        public int ManufacturerId { get; set; }
        public virtual Manufacturer Manufacturer { get; set; }
    }
}
