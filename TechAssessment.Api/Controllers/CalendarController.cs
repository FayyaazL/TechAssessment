using Microsoft.AspNetCore.Mvc;
using TechAssessment.Core.Entities;
using TechAssessment.Services.Interfaces;

namespace TechAssessment.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalendarController : ControllerBase
    {
        private readonly ICalendarService _calendarService;

        public CalendarController(ICalendarService calendarService)
        {
            _calendarService = calendarService;
        }

        [HttpPost("events/{eventId}/attendees/{attendeeId}")]
        public async Task<IActionResult> AddAttendeeToEvent(int eventId, int attendeeId)
        {
            await _calendarService.AddAttendeeToEventAsync(eventId, attendeeId);
            return Ok();
        }

        [HttpDelete("events/{eventId}/attendees/{attendeeId}")]
        public async Task<IActionResult> RemoveAttendeeFromEvent(int eventId, int attendeeId)
        {
            await _calendarService.RemoveAttendeeFromEventAsync(eventId, attendeeId);
            return Ok();
        }

    }
}
