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
        public string Name { get; set; }

        [Required]
        public string Password { get; set; } 

        [Required]
        public DateTime DateOfBirth { get; set; }

        [Required]
        public string ContactNo { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Address { get; set; }

        public DateTime HireDate { get; set; }

        [Required]
        public string Position { get; set; }

        [Required]
        public int OutletId { get; set; }
        public virtual Outlet Outlet { get; set; }
    }
}