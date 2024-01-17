﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JJRentals.Shared.Domain
{
	public class Car : BaseDomainModel
	{
		[Required]
		public int Year { get; set; }
        [Required]
        [RegularExpression(@"^[A-Za-z]{3}\d{4}[A-Za-z]", ErrorMessage = "License Plate Number does not meet requirements")]
        public string? LicensePlateNumber { get; set; }
        [Required]
        public int? MakeId { get; set; }
		public virtual Manufacturer? Manufacturer { get; set; }
        [Required]
        public int? ModelId { get; set; }
		public virtual Model? Model { get; set; }
        [Required]
        public int? ColourId { get; set; }
		public virtual Colour? Colour { get; set; }
		public virtual List<Booking>? Bookings { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        public double RentalRate { get; set; }
	}
}