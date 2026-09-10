using Microsoft.AspNetCore.Mvc;
using TechAssessment.Core.Entities;
using TechAssessment.Services.Interfaces;

namespace TechAssessment.Api.Controllers
{
    public class EntityControllerBase<T> : ControllerBase
    {
        protected readonly IEnitityService<T> _eventService;

        public EntityControllerBase(IEnitityService<T> eventService)
        {
            _eventService = eventService;
        }

        [HttpGet("Get")]
        public async Task<T> Get(int id)
        {
            throw new NotImplementedException();
        }

        [HttpPost("Create")]
        public async Task<IActionResult> Create([FromBody] T entity)
        {
            throw new NotImplementedException();
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update(int id, [FromBody] T entity)
        {
            throw new NotImplementedException();
        }

        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
