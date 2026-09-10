using Microsoft.AspNetCore.Mvc;
using TechAssessment.Core.Entities;
using TechAssessment.Services.Interfaces;

namespace TechAssessment.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalendarEventController : CalendarEntityControllerBase<CalendarEvent>
    {
        public CalendarEventController(ICalendarEntityService<CalendarEvent> eventService) : base(eventService)
        {
        }

        [HttpPost("CreateCalendarEvent")]
        public async Task<IActionResult> AddEventAsync(string title, string description, DateTime startTime, DateTime endTime)
        {
            var calendarEvent = new CalendarEvent { Title = title, Description = description, StartTime = startTime, EndTime = endTime };
            await _entityService.CreateAsync(calendarEvent);
            return Ok(calendarEvent);
        }
    }
}
