using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using JJRentals.Server.IRepository;
using JJRentals.Shared.Domain;
using Microsoft.AspNetCore.Authorization;

namespace JJRentals.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManufacturersController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public ManufacturersController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Manufacturers
        [HttpGet]
        public async Task<IActionResult> GetManufacturers()
        {
            if (_unitOfWork.Manufacturers == null)
            {
                return NotFound();
            }

            var manufacturers = await _unitOfWork.Manufacturers.GetAll();
            return Ok(manufacturers);
        }

        // GET: api/Manufacturers/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetManufacturers(int id)
        {
            if (_unitOfWork.Manufacturers == null)
            {
                return NotFound();
            }
            var manufacturer = await _unitOfWork.Manufacturers.Get(q => q.Id == id); 
            if (manufacturer == null)
            {
                return NotFound();
            }

            return Ok(manufacturer);
        }

        // PUT: api/Manufacturers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutManufacturer(int id, Manufacturer manufacturer)
        {
            if (id != manufacturer.Id)
            {
                return BadRequest();
            }

            _unitOfWork.Manufacturers.Update(manufacturer);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await ManufacturerExists(id))
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

        // POST: api/Manufacturers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Manufacturer>> PostManufacturer(Manufacturer manufacturer)
        {
            if (_unitOfWork.Manufacturers == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Manufacturers'  is null.");
            }
            await _unitOfWork.Manufacturers.Insert(manufacturer);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetManufacturer", new { id = manufacturer.Id }, manufacturer);
        }

        // DELETE: api/Manufacturers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteManufacturer(int id)
        {

            var manufacturer = await _unitOfWork.Manufacturers.Get(q => q.Id == id);
            if (manufacturer == null)
            {
                return NotFound();
            }

            await _unitOfWork.Manufacturers.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> ManufacturerExists(int id)
        {
            var manufacturer = await _unitOfWork.Manufacturers.Get(q => q.Id == id);
            return manufacturer != null;
        }
    }
}
