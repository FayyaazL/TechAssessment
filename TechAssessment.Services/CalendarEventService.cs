using TechAssessment.Core.Entities;
using TechAssessment.Services.Interfaces;

namespace TechAssessment.Services
{
    public class CalendarEventService : ICalendarEntityService<CalendarEvent>
    {
        public Task CreateAsync(CalendarEvent? entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CalendarEvent>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<CalendarEvent> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(int id, CalendarEvent? entity)
        {
            throw new NotImplementedException();
        }
    }
}
