using Microsoft.EntityFrameworkCore;
using TechAssessment.Core.Entities;
using TechAssessment.Repositories.DbContexts;

namespace TechAssessment.Repositories
{
    public class AttendeeRepository : CalendarEntityBaseRepository<Attendee>
    {
        public AttendeeRepository(CalendarDbContext dbContext) : base(dbContext)
        {
        }

        public override async Task<IEnumerable<Attendee>> GetAllAsync()
        {
            return await _dbContext.Attendees
                .Include(a => a.Events)
                .Select(a => new Attendee
                {
                    Id = a.Id,
                    Name = a.Name,
                    Email = a.Email,
                    Events = a.Events
                        .Select(e => new CalendarEvent
                        {
                            Id = e.Id,
                            Title = e.Title,
                            Description = e.Description,
                            StartTime = e.StartTime,
                            EndTime = e.EndTime,
                            Attendees = new List<Attendee>() // break cycle
                        })
                        .ToList()
                })
                .ToListAsync();
        }

        public override async Task<Attendee> GetByIdAsync(int id)
        {
            return await _dbContext.Attendees
                .Where(a => a.Id == id)
                .Include(a => a.Events)
                .Select(a => new Attendee
                {
                    Id = a.Id,
                    Name = a.Name,
                    Email = a.Email,
                    Events = a.Events
                        .Select(e => new CalendarEvent
                        {
                            Id = e.Id,
                            Title = e.Title,
                            Description = e.Description,
                            StartTime = e.StartTime,
                            EndTime = e.EndTime,
                            Attendees = new List<Attendee>() // break cycle
                        })
                        .ToList()
                })
                .FirstOrDefaultAsync();
        }
    }
}
