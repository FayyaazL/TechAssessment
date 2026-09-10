using Microsoft.AspNetCore.Mvc;
using TechAssessment.Core.Entities;
using TechAssessment.Services.Interfaces;

namespace TechAssessment.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AttendeeController : CalendarEntityControllerBase<Attendee>
    {
        private readonly ICalendarEntityService<Attendee> _attendeeService;

        public AttendeeController(ICalendarEntityService<Attendee> attendeeService) : base(attendeeService)
        {
            _attendeeService = attendeeService;
        }
    }
}
