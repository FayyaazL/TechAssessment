using Microsoft.EntityFrameworkCore;
using TechAssessment.Core.Entities;

namespace TechAssessment.Repositories.DbContexts
{
    public class CalendarDbContext : DbContext
    {
        public DbSet<Attendee> Attendees { get; set; }
        public DbSet<CalendarEvent> Events { get; set; }

        public CalendarDbContext(DbContextOptions<CalendarDbContext> options) : base(options)
        {
        }
    }
}
