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
    public class ClassesController : ControllerBase
    {
        private readonly educationmanagerContext _context;

        public ClassesController(educationmanagerContext context)
        {
            _context = context;
        }
        // GET: api/Classes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Class>>> GetClasses()
        {
            return await _context.Classes.ToListAsync();
        }

        // GET: api/Classes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Class>> GetClass(int id)
        {
            var classes = await _context.Classes.FindAsync(id);

            if (classes == null)
            {
                return NotFound();
            }

            return classes;
        }

        // PUT: api/Classes/5
        // To protect from overposting attacks,see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> Putclass(int id, Class classes)
        {
            if (id != classes.Id)
            {
                return BadRequest();
            }

            _context.Entry(classes).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClassExists(id))
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

        // POST: api/Classes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Class>> PostClass(Class classes)
        {
            _context.Classes.Add(classes);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetClass", new { id = classes.Id }, classes);
        }

        // DELETE: api/Classes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteClass(int id)
        {
            var classes = await _context.Classes.FindAsync(id);
            if (classes == null)
            {
                return NotFound();
            }

            _context.Classes.Remove(classes);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ClassExists(int id)
        {
            return _context.Exams.Any(e => e.Id == id);
        }
    }
}
