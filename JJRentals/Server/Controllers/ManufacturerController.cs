using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using JJRentals.Server.IRepository;
using JJRentals.Shared.Domain;

namespace JJRentals.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManufacturerController : ControllerBase
    {
        //Refactored
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        //Refactored
        //public MakesController(ApplicationDbContext context)
        public ManufacturerController(IUnitOfWork unitOfWork)
        {
            //Refactored
            //_context = context;
            _unitOfWork = unitOfWork;
        }

        // GET: api/Manufacturers
        [HttpGet]
        //public async Task<ActionResult<IEnumerable<Manufacturer>>> GetMakes()
        public async Task<IActionResult> GetMakes()
        {
            //Refactored
            if (_unitOfWork.Manufacturers == null)
            {
                return NotFound();
            }

            //return await _context.Manufacturers.ToListAsync();
            var manus = await _unitOfWork.Manufacturers.GetAll();
            return Ok(manus);
        }

        // GET: api/Manufacturers/5
        [HttpGet("{id}")]
        //public async Task<ActionResult<Manufacturer>> GetMake(int id)
        public async Task<IActionResult> GetMakes(int id)
        {
            if (_unitOfWork.Manufacturers == null)
            {
                return NotFound();
            }
            //var manu = await _context.Manufacturers.FindAsync(id);
            var manu = await _unitOfWork.Manufacturers.Get(q => q.Id == id); /* lamda expression: find instance of q, where q is of "Manufacturers" type, so finding a instance of q with a specific Id that is equals to the id parsed*/

            if (manu == null)
            {
                return NotFound();
            }

            return Ok(manu);
        }

        // PUT: api/Manufacturers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMake(int id, Manufacturer manu)
        {
            if (id != manu.Id)
            {
                return BadRequest();
            }

            //Refactored
            //_context.Entry(manu).State = EntityState.Modified;
            _unitOfWork.Manufacturers.Update(manu);

            try
            {
                //Refactored
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                //Refactored
                //if (!MakeExists(id))
                if (!await MakeExists(id))
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
        public async Task<ActionResult<Manufacturer>> PostMake(Manufacturer manu)
        {
            if (_unitOfWork.Manufacturers == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Manufacturers'  is null.");
            }
            await _unitOfWork.Manufacturers.Insert(manu);
            await _unitOfWork.Save(HttpContext);
            //_context.Manufacturers.Add(manu);
            //await _context.SaveChangesAsync();

            return CreatedAtAction("GetMake", new { id = manu.Id }, manu);
        }

        // DELETE: api/Manufacturers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMake(int id)
        {
            //if (_context.Manufacturers == null)
            //{
            // return NotFound();
            // }

            var manu = await _unitOfWork.Manufacturers.Get(q => q.Id == id);
            //var manu = await _context.Manufacturers.FindAsync(id);
            if (manu == null)
            {
                return NotFound();
            }

            ///_context.Manufacturers.Remove(manu);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Manufacturers.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> MakeExists(int id)
        {
            //return (_context.Manufacturers?.Any(e => e.Id == id)).GetValueOrDefault();
            var manu = await _unitOfWork.Manufacturers.Get(q => q.Id == id);
            return manu != null;
        }
    }
}
