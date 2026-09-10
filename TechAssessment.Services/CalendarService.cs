using TechAssessment.Core.Entities;
using TechAssessment.Repositories.Interfaces;
using TechAssessment.Services.Interfaces;

namespace TechAssessment.Services
{
    public class CalendarService : ICalendarService
    {
        private readonly ICalendarEntityRepository<CalendarEvent> _calendarEventRepository;
        private readonly ICalendarEntityRepository<Attendee> _attendeeRepository;

        public CalendarService(ICalendarEntityRepository<CalendarEvent> calendarEventRepository, ICalendarEntityRepository<Attendee> attendeeRepository)
        {
            _calendarEventRepository = calendarEventRepository;
            _attendeeRepository = attendeeRepository;
        }

        public async Task AddAttendeeToEventAsync(int calendarEventId, int attendeeId)
        {
            var calendarEvent = await _calendarEventRepository.GetByIdAsync(calendarEventId);
            var attendee = await _attendeeRepository.GetByIdAsync(attendeeId);
            calendarEvent.Attendees.Add(attendee);
            attendee.Events.Add(calendarEvent);
            await _calendarEventRepository.UpdateAsync(calendarEvent);
            await _attendeeRepository.UpdateAsync(attendee);
        }

        public async Task RemoveAttendeeFromEventAsync(int calendarEventId, int attendeeId)
        {
            var calendarEvent = await _calendarEventRepository.GetByIdAsync(calendarEventId);
            var attendee = await _attendeeRepository.GetByIdAsync(attendeeId);
            calendarEvent.Attendees.Remove(attendee);
            attendee.Events.Remove(calendarEvent);
            await _calendarEventRepository.UpdateAsync(calendarEvent);
            await _attendeeRepository.UpdateAsync(attendee);
        }
    }
}

