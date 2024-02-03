using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JJRentals.Shared.Domain
{
    public class Image : BaseDomainModel
    {
        [Required(ErrorMessage = "Image file URL is required.")]
        [Url(ErrorMessage = "The ImgFileURL must be a valid URL.")]
        public string ImgFileURL { get; set; }

        [Required(ErrorMessage = "Car ID is required.")]
        public int CarId { get; set; }
        public virtual Car? Car { get; set; }
    }
}
