using TechAssessment.Core.Entities;
using TechAssessment.Repositories.Interfaces;

namespace TechAssessment.Services
{
    public class AttendeeService : CalendarEntityBaseService<Attendee>
    {
        public AttendeeService(ICalendarEntityRepository<Attendee> attendeeRepository) : base(attendeeRepository)
        {
        }
    }
}
