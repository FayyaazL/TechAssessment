using Microsoft.AspNetCore.Mvc;
using TechAssessment.Core.Entities;
using TechAssessment.Services.Interfaces;

namespace TechAssessment.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalendarEventController : CalendarEntityControllerBase<CalendarEvent>
    {
        private readonly ICalendarEntityService<CalendarEvent> _eventService;

        public CalendarEventController(ICalendarEntityService<CalendarEvent> eventService) : base(eventService)
        {
            _eventService = eventService;
        }
    }
}
