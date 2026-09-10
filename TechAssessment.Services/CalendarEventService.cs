using TechAssessment.Core.Entities;
using TechAssessment.Repositories.Interfaces;

namespace TechAssessment.Services
{
    public class CalendarEventService : CalendarEntityBaseService<CalendarEvent>
    {
        public CalendarEventService(ICalendarEntityRepository<CalendarEvent> calendarEventRepository) : base(calendarEventRepository)
        {
        }
    }
}