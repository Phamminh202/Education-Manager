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
    public class AttendanceReportsController : ControllerBase
    {
        private readonly educationmanagerContext _context;
        public AttendanceReportsController(educationmanagerContext context)
        {
            _context = context;
        }
        // GET: api/AttendanceReports
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AttendanceReport>>> GetAttendanceReports()
        {
            return await _context.AttendanceReports.ToListAsync();
        }
        // GET: api/AttendanceReports/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AttendanceReport>> GetAttendanceReports(int id)
        {
            var attendancereport = await _context.AttendanceReports.FindAsync(id);

            if (attendancereport == null)
            {
                return NotFound();
            }

            return attendancereport;
        }

        // POST: api/AttendanceReports
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<AttendanceReport>> PostAttendanceReports(AttendanceReport attendancereport)
        {
            _context.AttendanceReports.Add(attendancereport);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetExam", new { id = attendancereport.Id }, attendancereport);
        }
    }
}
