using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SimpleTimeSheets.Models;
using TimeSheetApi.Context;

namespace TimeSheetApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TimeSheetController : ControllerBase
    {
        private readonly TimeSheetContext _context;

        public TimeSheetController(TimeSheetContext context)
        {
            _context = context;

            if(_context.TimeSheets.Count() == 0)
            {
                _context.TimeSheets.Add(new TimeSheet
                {
                    WeekNumber = 22,
                    HoursWorkedOnSunday = 1.5,
                    HoursWorkedOnMonday = 7.25,
                    HoursWorkedOnTuesday = 6.5,
                    HoursWorkedOnWednesday = 6,
                    HoursWorkedOnThursday = 7.25,
                    HoursWorkedOnFriday = 7,
                    HoursWorkedOnSaturday = 0
                });
                _context.SaveChanges();
            }
        }

        // GET: api/TimeSheet
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TimeSheet>>> GetTimeSheets()
        {
            return await _context.TimeSheets.ToListAsync();
        }

        // GET: api/TimeSheet/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TimeSheet>> GetTimeSheet(int id)
        {
            var timeSheet = await _context.TimeSheets.FindAsync(id);

            if (timeSheet == null)
            {
                return NotFound();
            }

            return timeSheet;
        }

        // POST: api/TimeSheet
        [HttpPost]
        public async Task<ActionResult<TimeSheet>> PostTimeSheet(TimeSheet timeSheet)
        {
            _context.TimeSheets.Add(timeSheet);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetTimeSheet), new { id = timeSheet.Id }, timeSheet);
        }

        // PUT: api/TimeSheet/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTimeSheet(int id, TimeSheet timeSheet)
        {
            if (id != timeSheet.Id)
            {
                return BadRequest();
            }

            _context.Entry(timeSheet).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TimeSheetExists(id))
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

        // DELETE: api/TimeSheet/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTimesheet(int id)
        {
            var timeSheet = await _context.TimeSheets.FindAsync(id);
            if (timeSheet == null)
            {
                return NotFound();
            }

            _context.TimeSheets.Remove(timeSheet);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TimeSheetExists(int id)
        {
            return _context.TimeSheets.Any(e => e.Id == id);
        }
    }
}
