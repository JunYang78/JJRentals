using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using JJRentals.Server.IRepository;
using JJRentals.Shared.Domain;

namespace JJRentals.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManufacturersController : ControllerBase
    {
        //Refactored
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        //Refactored
        //public ManufacturersController(ApplicationDbContext context)
        public ManufacturersController(IUnitOfWork unitOfWork)
        {
            //Refactored
            //_context = context;
            _unitOfWork = unitOfWork;
        }

        // GET: api/Manufacturers
        [HttpGet]
        //public async Task<ActionResult<IEnumerable<Manufacturer>>> GetManufacturers()
        public async Task<IActionResult> GetManufacturers()
        {
            //Refactored
            if (_unitOfWork.Manufacturers == null)
            {
                return NotFound();
            }

            //return await _context.Manufacturers.ToListAsync();
            var manufacturers = await _unitOfWork.Manufacturers.GetAll();
            return Ok(manufacturers);
        }

        // GET: api/Manufacturers/5
        [HttpGet("{id}")]
        //public async Task<ActionResult<Manufacturer>> GetManufacturer(int id)
        public async Task<IActionResult> GetManufacturers(int id)
        {
            if (_unitOfWork.Manufacturers == null)
            {
                return NotFound();
            }
            //var manufacturer = await _context.Manufacturers.FindAsync(id);
            var manufacturer = await _unitOfWork.Manufacturers.Get(q => q.Id == id); /* lamda expression: find instance of q, where q is of "Manufacturers" type, so finding a instance of q with a specific Id that is equals to the id parsed*/

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

            //Refactored
            //_context.Entry(manufacturer).State = EntityState.Modified;
            _unitOfWork.Manufacturers.Update(manufacturer);

            try
            {
                //Refactored
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                //Refactored
                //if (!ManufacturerExists(id))
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
            //_context.Manufacturers.Add(manufacturer);
            //await _context.SaveChangesAsync();

            return CreatedAtAction("GetManufacturer", new { id = manufacturer.Id }, manufacturer);
        }

        // DELETE: api/Manufacturers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteManufacturer(int id)
        {
            //if (_context.Manufacturers == null)
            //{
            // return NotFound();
            // }

            var manufacturer = await _unitOfWork.Manufacturers.Get(q => q.Id == id);
            //var manufacturer = await _context.Manufacturers.FindAsync(id);
            if (manufacturer == null)
            {
                return NotFound();
            }

            ///_context.Manufacturers.Remove(manufacturer);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Manufacturers.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> ManufacturerExists(int id)
        {
            //return (_context.Manufacturers?.Any(e => e.Id == id)).GetValueOrDefault();
            var manufacturer = await _unitOfWork.Manufacturers.Get(q => q.Id == id);
            return manufacturer != null;
        }
    }
}
