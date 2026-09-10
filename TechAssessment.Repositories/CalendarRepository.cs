using TechAssessment.Repositories.DbContexts;
using TechAssessment.Repositories.Interfaces;

namespace TechAssessment.Repositories
{
    public class CalendarRepository : ICalendarRepository
    {
        CalendarDbContext _dbContext;

        public CalendarRepository(CalendarDbContext dbContext) {
            _dbContext = dbContext;
        }
    }
}
