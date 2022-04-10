using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EducationManager.API.Models;

namespace EducationManager.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TimetablesController : ControllerBase
    {
        private readonly educationmanagerContext _context;
        public TimetablesController(educationmanagerContext context)
        {
            _context = context;
        }
        // GET: api/Timetables
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Timetable>>> GetTimetables()
        {
            return await _context.Timetables.ToListAsync();
        }

        // GET: api/Timetables/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Timetable>> GetTimetable(int id)
        {
            var timetable = await _context.Timetables.FindAsync(id);

            if (timetable == null)
            {
                return NotFound();
            }

            return timetable;
        }

        // PUT: api/Timetables/5
        // To protect from overposting attacks,see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTimetable(int id, Timetable timetable)
        {
            if (id != timetable.Id)
            {
                return BadRequest();
            }

            _context.Entry(timetable).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TimetableExists(id))
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

        // POST: api/Timetables
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Timetable>> PostTimetalbe(Timetable timetable)
        {
            _context.Timetables.Add(timetable);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetExam", new { id = timetable.Id }, timetable);
        }

        // DELETE: api/Timetables/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTimetable(int id)
        {
            var timetable = await _context.Timetables.FindAsync(id);
            if (timetable == null)
            {
                return NotFound();
            }

            _context.Timetables.Remove(timetable);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TimetableExists(int id)
        {
            return _context.Exams.Any(e => e.Id == id);
        }
    }
}
