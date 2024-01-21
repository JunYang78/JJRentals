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
    public class MaintenancesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public MaintenancesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Maintenances
        [HttpGet]
        public async Task<IActionResult> GetMaintenances()
        {
            var maintenances = await _unitOfWork.Maintenances.GetAll(includes: q => q.Include(x => x.Car).Include(x => x.Staff));
            return Ok(maintenances);
        }

        // GET: api/Maintenances/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMaintenance(int id)
        {
            var maintenance = await _unitOfWork.Maintenances.Get(q => q.Id == id);

            if (maintenance == null)
            {
                return NotFound();
            }

            return Ok(maintenance);
        }

        // PUT: api/Maintenances/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMaintenance(int id, Maintenance maintenance)
        {
            if (id != maintenance.Id)
            {
                return BadRequest();
            }

            _unitOfWork.Maintenances.Update(maintenance);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await MaintenanceExists(id))
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

        // POST: api/Maintenances
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Maintenance>> PostMaintenance(Maintenance maintenance)
        {
            await _unitOfWork.Maintenances.Insert(maintenance);
            await _unitOfWork.Save(HttpContext);


            return CreatedAtAction("GetMaintenance", new { id = maintenance.Id }, maintenance);
        }

        // DELETE: api/Maintenances/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMaintenance(int id)
        {
            var maintenance = await _unitOfWork.Maintenances.Get(q => q.Id == id);
            if (maintenance == null)
            {
                return NotFound();
            }

            await _unitOfWork.Maintenances.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> MaintenanceExists(int id)
        {
            var maintenance = await _unitOfWork.Maintenances.Get(q => q.Id == id);
            return maintenance != null;
        }
    }
}
