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
        [StringLength(100, ErrorMessage = "CarPlate Number must be between 2 and 100 characters", MinimumLength = 2)]
        public string CarPlate { get; set; }

        [Required]
        [Range(1900, 2100, ErrorMessage = "Year must be between 1900 and 2100")]
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
        public virtual Outlet? Outlet { get; set; }

        [Required]
        public int ModelId { get; set; }
        public virtual Model? Model { get; set; }
    }
}