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
    public class OutletsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public OutletsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Outlets
        [HttpGet]
        public async Task<IActionResult> GetOutlets()
        {
            var outlets = await _unitOfWork.Outlets.GetAll();
            return Ok(outlets);
        }

        // GET: api/Outlets/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetOutlet(int id)
        {
            var Outlet = await _unitOfWork.Outlets.Get(q => q.Id == id);

            if (Outlet == null)
            {
                return NotFound();
            }

            return Ok(Outlet);
        }

        // PUT: api/Outlets/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOutlet(int id, Outlet outlet)
        {
            if (id != outlet.Id)
            {
                return BadRequest();
            }

            _unitOfWork.Outlets.Update(outlet);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await OutletExists(id))
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

        // POST: api/Outlets
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Outlet>> PostOutlet(Outlet outlet)
        {
            await _unitOfWork.Outlets.Insert(outlet);
            await _unitOfWork.Save(HttpContext);


            return CreatedAtAction("GetOutlet", new { id = outlet.Id }, outlet);
        }

        // DELETE: api/Outlets/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOutlet(int id)
        {
            var outlet = await _unitOfWork.Outlets.Get(q => q.Id == id);
            if (outlet == null)
            {
                return NotFound();
            }

            await _unitOfWork.Outlets.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> OutletExists(int id)
        {
            var outlet = await _unitOfWork.Outlets.Get(q => q.Id == id);
            return outlet != null;
        }
    }
}
