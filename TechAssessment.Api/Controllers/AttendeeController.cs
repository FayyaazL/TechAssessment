using Microsoft.AspNetCore.Mvc;
using TechAssessment.Core.Entities;
using TechAssessment.Services.Interfaces;

namespace TechAssessment.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AttendeeController : EntityControllerBase<Attendee>
    {
        private readonly IEnitityService<Attendee> _attendeeService;

        public AttendeeController(IEnitityService<Attendee> attendeeService) : base(attendeeService)
        {
            _attendeeService = attendeeService;
        }
    }
}
