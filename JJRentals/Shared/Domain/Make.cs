using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JJRentals.Shared.Domain
{
	public class Manufacturer : BaseDomainModel
	{
		[Required]
		public string? Name { get; set; }
	}
}
