using Microsoft.AspNetCore.Mvc;
using TechAssessment.Core.Entities;
using TechAssessment.Services.Interfaces;

namespace TechAssessment.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EventController : EntityControllerBase<Event>
    {
        private readonly IEnitityService<Event> _eventService;

        public EventController(IEnitityService<Event> eventService) : base(eventService)
        {
            _eventService = eventService;
        }
    }
}
