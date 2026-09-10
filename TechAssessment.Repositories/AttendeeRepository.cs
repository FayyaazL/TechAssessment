using TechAssessment.Core.Entities;
using TechAssessment.Repositories.DbContexts;

namespace TechAssessment.Repositories
{
    public class AttendeeRepository : CalendarEntityBaseRepository<Attendee>
    {
        public AttendeeRepository(CalendarDbContext dbContext) : base(dbContext)
        {
        }
    }
}
