using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EducationManager.API.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EducationManager.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AcademicyearsController : ControllerBase
    {
        private readonly educationmanagerContext _context;

        public AcademicyearsController(educationmanagerContext context)
        {
            _context = context;
        }
        // GET: api/Academicyears
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Academicyear>>> GetAcademicyears()
        {
            return await _context.Academicyears.ToListAsync();
        }

        // GET: api/Academicyears/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Academicyear>> GetAcademicyear(int id)
        {
            var academicyear = await _context.Academicyears.FindAsync(id);

            if (academicyear == null)
            {
                return NotFound();
            }

            return academicyear;
        }

        // PUT: api/Academicyears/5
        // To protect from overposting attacks,see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAcademicyear(int id, Academicyear academicyear)
        {
            if (id != academicyear.Id)
            {
                return BadRequest();
            }

            _context.Entry(academicyear).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AcademicyearExists(id))
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

        // POST: api/Academicyears
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Academicyear>> PostAcademicyear(Academicyear academicyear)
        {
            _context.Academicyears.Add(academicyear);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAcademicyear", new { id = academicyear.Id }, academicyear);
        }

        // DELETE: api/StudentFees/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAcademicyear(int id)
        {
            var academicyear = await _context.Academicyears.FindAsync(id);
            if (academicyear == null)
            {
                return NotFound();
            }

            _context.Academicyears.Remove(academicyear);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AcademicyearExists(int id)
        {
            return _context.Exams.Any(e => e.Id == id);
        }
    }
}
