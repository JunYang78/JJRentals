using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JJRentals.Shared.Domain
{
	public class Car : BaseDomainModel
	{
        [Required]
        public string CarPlate { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        [Column(TypeName = "decimal(10, 2)")]
        public decimal CarRentPerHour { get; set; }

        [Required]
        [Column(TypeName = "decimal(10, 2)")]
        public decimal CarRentPerDay { get; set; }

        [Required]
        public string Colour { get; set; }

        public bool Availability { get; set; }

        [Required]
        public int OutletId { get; set; }
        public virtual Outlet Outlet { get; set; }

        [Required]
        public int ModelId { get; set; }
        public virtual Model Model { get; set; }
    }
}
