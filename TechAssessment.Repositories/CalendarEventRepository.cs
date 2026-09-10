using Microsoft.EntityFrameworkCore;
using TechAssessment.Core.Entities;
using TechAssessment.Repositories.DbContexts;

namespace TechAssessment.Repositories
{
    public class CalendarEventRepository : CalendarEntityBaseRepository<CalendarEvent>
    {
        public CalendarEventRepository(CalendarDbContext dbContext) : base(dbContext)
        {
        }
        public override async Task<IEnumerable<CalendarEvent>> GetAllAsync()
        {
            return await _dbContext.Events
                .Include(e => e.Attendees)
                .Select(e => new CalendarEvent
                {
                    Id = e.Id,
                    Title = e.Title,
                    Description = e.Description,
                    StartTime = e.StartTime,
                    EndTime = e.EndTime,
                    Attendees = e.Attendees
                        .Select(a => new Attendee
                        {
                            Id = a.Id,
                            Name = a.Name,
                            Email = a.Email,
                            Events = new List<CalendarEvent>() // break cycle
                        })
                        .ToList()
                })
                .ToListAsync();
        }

        public override async Task<CalendarEvent> GetByIdAsync(int id)
        {
            return await _dbContext.Events
                .Where(e => e.Id == id)
                .Include(e => e.Attendees)
                .Select(e => new CalendarEvent
                {
                    Id = e.Id,
                    Title = e.Title,
                    Description = e.Description,
                    StartTime = e.StartTime,
                    EndTime = e.EndTime,
                    Attendees = e.Attendees
                        .Select(a => new Attendee
                        {
                            Id = a.Id,
                            Name = a.Name,
                            Email = a.Email,
                            Events = new List<CalendarEvent>() // break cycle
                        })
                        .ToList()
                })
                .FirstOrDefaultAsync();
        }
    }
}
