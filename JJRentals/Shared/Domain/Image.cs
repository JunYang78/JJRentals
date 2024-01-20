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
        [Required]
        public string ImgFileURL { get; set; }

        [Required]
        public int CarId { get; set; }
        public virtual Car Car { get; set; }
    }
}
