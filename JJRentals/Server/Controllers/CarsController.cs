using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using JJRentals.Server.Data;
using JJRentals.Server.IRepository;
using JJRentals.Shared.Domain;

namespace JJRentals.Server.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class carsController : ControllerBase
	{
		private readonly IUnitOfWork _unitOfWork;

		public carsController(IUnitOfWork unitOfWork)
		{
			_unitOfWork = unitOfWork;
		}

		// GET: api/Cars
		[HttpGet]
		public async Task<IActionResult> Getcars()
		{
			var cars = await _unitOfWork.Cars.GetAll(includes:q=>q.Include(x=>x.Model));
			return Ok(cars);
		}

		// GET: api/Cars/5
		[HttpGet("{id}")]
		public async Task<IActionResult> GetCar(int id)
		{
			var car = await _unitOfWork.Cars.Get(q => q.Id == id);

			if (car == null)
			{
				return NotFound();
			}

			return Ok(car);
		}

		// PUT: api/Cars/5
		// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
		[HttpPut("{id}")]
		public async Task<IActionResult> PutCar(int id, Car car)
		{
			if (id != car.Id)
			{
				return BadRequest();
			}

			_unitOfWork.Cars.Update(car);

			try
			{
				await _unitOfWork.Save(HttpContext);
			}
			catch (DbUpdateConcurrencyException)
			{
				if (!await CarExists(id))
				{
					return NotFound();
				}
				else
				{
					throw;
				}
			}

			return NoContent();
		}

		// POST: api/Cars
		// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
		[HttpPost]
		public async Task<ActionResult<Car>> PostCar(Car car)
		{
			await _unitOfWork.Cars.Insert(car);
			await _unitOfWork.Save(HttpContext);


			return CreatedAtAction("GetCar", new { id = car.Id }, car);
		}

		// DELETE: api/Cars/5
		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteCar(int id)
		{
			var car = await _unitOfWork.Cars.Get(q => q.Id == id);
			if (car == null)
			{
				return NotFound();
			}

			await _unitOfWork.Cars.Delete(id);
			await _unitOfWork.Save(HttpContext);

			return NoContent();
		}

		private async Task<bool> CarExists(int id)
		{
			var car = await _unitOfWork.Cars.Get(q => q.Id == id);
			return car != null;
		}
	}
}
