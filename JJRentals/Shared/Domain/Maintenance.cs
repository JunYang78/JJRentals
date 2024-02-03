using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JJRentals.Shared.Domain
{
    public class Maintenance : BaseDomainModel, IValidatableObject
    {
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime SentDate { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime ReturnDate { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Service provider name must be less than 100 characters long.")]
        public string ServiceProvider { get; set; }

        [Required]
        [StringLength(200, ErrorMessage = "Parts affected description must be less than 200 characters long.")]
        public string PartsAffected { get; set; }

        [Required]
        [Column(TypeName = "decimal(10, 2)")]
        public decimal Cost { get; set; }

        [Required]
        public int StaffId { get; set; }
        public virtual Staff? Staff { get; set; }

        [Required]
        public int CarId { get; set; }
        public virtual Car? Car { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            //throw new NotImplementedException();

            if (SentDate != null)
            {
                if (ReturnDate < SentDate)
                {
                    yield return new ValidationResult("Return date must be greater than Sent date", new[] { "ReturnDate" });
                }
            }
        }
    }
}