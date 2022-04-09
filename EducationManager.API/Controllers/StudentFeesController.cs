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
    public class StudentFeesController : ControllerBase
    {
        private readonly educationmanagerContext _context;

        public StudentFeesController(educationmanagerContext context)
        {
            _context = context;
        }
        // GET: api/StudentFees
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StudentFee>>> GetStudentFees()
        {
            return await _context.StudentFees.ToListAsync();
        }

        // GET: api/StudentFees/5
        [HttpGet("{id}")]
        public async Task<ActionResult<StudentFee>> GetStudentFee(int id)
        {
            var studentfee = await _context.StudentFees.FindAsync(id);

            if (studentfee == null)
            {
                return NotFound();
            }

            return studentfee;
        }

        // PUT: api/StudentFees/5
        // To protect from overposting attacks,see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStudentFee(int id, StudentFee studentfee)
        {
            if (id != studentfee.Id)
            {
                return BadRequest();
            }

            _context.Entry(studentfee).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StudentFeeExists(id))
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

        // POST: api/StudentFees
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<StudentFee>> PostExam(StudentFee studentfee)
        {
            _context.StudentFees.Add(studentfee);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetStudentFee", new { id = studentfee.Id }, studentfee);
        }

        // DELETE: api/StudentFees/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStudentFee(int id)
        {
            var studentfeee = await _context.StudentFees.FindAsync(id);
            if (studentfeee == null)
            {
                return NotFound();
            }

            _context.StudentFees.Remove(studentfeee);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool StudentFeeExists(int id)
        {
            return _context.Exams.Any(e => e.Id == id);
        }
    }
}
