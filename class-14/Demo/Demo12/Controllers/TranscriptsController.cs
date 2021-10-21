using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Demo12.Data;
using Demo12.Models;

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

        // GET: api/Transcripts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Transcript>>> GetTranscripts(int studentId)
        {
            return await _context.Transcripts
                .Where(t => t.StudentId == studentId)
                .ToListAsync();
        }

        // GET: api/Transcripts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Transcript>> GetTranscript(int id)
        {
            var transcript = await _context.Transcripts.FindAsync(id);

            if (transcript == null)
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

        // POST: api/Transcripts
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Transcript>> PostTranscript(Transcript transcript)
        {
            _context.Transcripts.Add(transcript);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTranscript", new { id = transcript.Id }, transcript);
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
