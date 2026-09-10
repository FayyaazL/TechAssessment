using Microsoft.EntityFrameworkCore;

namespace TechAssessment.Repositories.DbContexts
{
    public class CalendarDbContext: DbContext
    {

        public CalendarDbContext(DbContextOptions<CalendarDbContext> options) : base(options)
        {
        }
    }
}
