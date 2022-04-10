using EducationManager.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EducationManager.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarksController : ControllerBase
    {
        private readonly educationmanagerContext _context;

        public MarksController(educationmanagerContext context)
        {
            _context = context;
        }
        // GET: api/Marks
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Mark>>> GetMarks()
        {
            return await _context.Marks.ToListAsync();
        }

        // GET: api/Marks/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Mark>> GetMark(int id)
        {
            var Mark = await _context.Marks.FindAsync(id);

            if (Mark == null)
            {
                return NotFound();
            }

            return Mark;
        }

        // PUT: api/Marks/5
        // To protect from overposting attacks,see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMark(int id, Mark Mark)
        {
            if (id != Mark.Id)
            {
                return BadRequest();
            }

            _context.Entry(Mark).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MarkExists(id))
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

        // POST: api/Marks
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Mark>> PostMark(Mark Mark)
        {
            _context.Marks.Add(Mark);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMark", new { id = Mark.Id }, Mark);
        }

        private bool MarkExists(int id)
        {
            return _context.Marks.Any(e => e.Id == id);
        }
    }
    
}
