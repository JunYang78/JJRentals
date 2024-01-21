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
	public class ImagesController : ControllerBase
	{
		private readonly IUnitOfWork _unitOfWork;

		public ImagesController(IUnitOfWork unitOfWork)
		{
			_unitOfWork = unitOfWork;
		}

		// GET: api/Images
		[HttpGet]
		public async Task<IActionResult> GetImages()
		{
            var images = await _unitOfWork.Images.GetAll(includes: q => q.Include(x => x.Car));
			return Ok(images);
		}

		// GET: api/Images/5
		[HttpGet("{id}")]
		public async Task<IActionResult> Getimage(int id)
		{
			var image = await _unitOfWork.Images.Get(q => q.Id == id);

			if (image == null)
			{
				return NotFound();
			}

			return Ok(image);
		}

		// PUT: api/Images/5
		// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
		[HttpPut("{id}")]
		public async Task<IActionResult> Putimage(int id, Image image)
		{
			if (id != image.Id)
			{
				return BadRequest();
			}

			_unitOfWork.Images.Update(image);

			try
			{
				await _unitOfWork.Save(HttpContext);
			}
			catch (DbUpdateConcurrencyException)
			{
				if (!await imageExists(id))
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

		// POST: api/Images
		// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
		[HttpPost]
		public async Task<ActionResult<Image>> Postimage(Image image)
		{
			await _unitOfWork.Images.Insert(image);
			await _unitOfWork.Save(HttpContext);


			return CreatedAtAction("Getimage", new { id = image.Id }, image);
		}

		// DELETE: api/Images/5
		[HttpDelete("{id}")]
		public async Task<IActionResult> Deleteimage(int id)
		{
			var image = await _unitOfWork.Images.Get(q => q.Id == id);
			if (image == null)
			{
				return NotFound();
			}

			await _unitOfWork.Images.Delete(id);
			await _unitOfWork.Save(HttpContext);

			return NoContent();
		}

		private async Task<bool> imageExists(int id)
		{
			var image = await _unitOfWork.Images.Get(q => q.Id == id);
			return image != null;
		}
	}
}

