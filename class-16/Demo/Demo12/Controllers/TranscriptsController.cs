using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Demo12.Data;
using Demo12.Models;
using Demo12.Models.DTO;

namespace Demo12.Controllers
{
    [Route("api/Students/{studentId}/Transcript")]
    [ApiController]
    public class TranscriptsController : ControllerBase
    {
        private readonly SchoolDbContext _context;

        public TranscriptsController(SchoolDbContext context)
        {
            _context = context;
        }

        // GET: api/Students/{studentId}/Transcripts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Transcript>>> GetTranscripts(int studentId)
        {
            // transcripts.GetAll(studentId)
            return await _context.Transcripts
                .Where(t => t.StudentId == studentId)
                .Include(t => t.Student)
                .Include(t => t.Course)
                .ToListAsync();
        }

        // GET: api/Students/{studentId}/Transcripts/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<Transcript>> GetTranscript(int studentId, int id)
        {
            var transcript = await _context.Transcripts
                .Include(t => t.Student)
                .Include(t => t.Course)
                // .ThenInclude(c => c.Technology)
                .FirstOrDefaultAsync(t => t.Id == id);

            if (transcript == null || transcript.StudentId != studentId)
            {
                return NotFound();
            }

            return transcript;
        }

        // PUT: api/Transcripts/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTranscript(int id, Transcript transcript)
        {
            if (id != transcript.Id)
            {
                return BadRequest();
            }

            // TODO: If studentId does not match transcript, return NotFound()

            _context.Entry(transcript).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TranscriptExists(id))
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

        // POST: api/Students/{studentId}/Transcripts
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Transcript>> PostTranscript(int studentId, CreateTranscriptData createData)
        {
            var student = await _context.Students.FindAsync(studentId);
            if (student == null)
            {
                return NotFound();
            }

            var course = await _context.Courses
                .FirstOrDefaultAsync(c => c.CourseCode == createData.CourseCode);
            if (course == null)
            {
                return BadRequest();
            }

            var transcript = new Transcript
            {
                StudentId = studentId,
                CourseId = course.Id,
                Grade = Enum.Parse<Grade>(createData.Grade), // enum from string
            };

            _context.Transcripts.Add(transcript);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTranscript", new { studentId, id = transcript.Id }, transcript);
        }

        // DELETE: api/Transcripts/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTranscript(int id)
        {
            var transcript = await _context.Transcripts.FindAsync(id);
            if (transcript == null)
            {
                return NotFound();
            }

            // TODO: If studentId does not match transcript, return NotFound()

            _context.Transcripts.Remove(transcript);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TranscriptExists(int id)
        {
            return _context.Transcripts.Any(e => e.Id == id);
        }
    }
}
