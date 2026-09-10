using TechAssessment.Core.Entities;
using TechAssessment.Repositories.DbContexts;

namespace TechAssessment.Repositories
{
    public class CalendarEventRepository : CalendarEntityBaseRepository<CalendarEvent>
    {
        public CalendarEventRepository(CalendarDbContext dbContext) : base(dbContext)
        {
        }
    }
}
