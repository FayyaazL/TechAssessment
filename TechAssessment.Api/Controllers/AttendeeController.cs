using Microsoft.AspNetCore.Mvc;
using TechAssessment.Core.Entities;
using TechAssessment.Services.Interfaces;

namespace TechAssessment.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AttendeeController : CalendarEntityControllerBase<Attendee>
    {
        public AttendeeController(ICalendarEntityService<Attendee> attendeeService) : base(attendeeService)
        {
        }

        [HttpPost("CreateAttendee")]
        public async Task<IActionResult> AddAttendeeAsync(string name, string email)
        {
            var attendee = new Attendee { Name = name, Email = email };
            await _entityService.CreateAsync(attendee);
            return Ok(attendee);
        }
    }
}
