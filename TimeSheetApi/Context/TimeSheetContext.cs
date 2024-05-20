using Microsoft.EntityFrameworkCore;
using SimpleTimeSheets.Models;

namespace TimeSheetApi.Context
{
    public class TimeSheetContext : DbContext
    {
        public TimeSheetContext(DbContextOptions<TimeSheetContext> options) : base(options) { }

        public DbSet<TimeSheet> TimeSheets {get; set;}
    }
}
