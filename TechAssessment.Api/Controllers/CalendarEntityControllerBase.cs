using Microsoft.AspNetCore.Mvc;
using TechAssessment.Core.Entities;
using TechAssessment.Services.Interfaces;

namespace TechAssessment.Api.Controllers
{
    public class CalendarEntityControllerBase<T> : ControllerBase
    {
        protected readonly ICalendarEntityService<T> _entityService;

        public CalendarEntityControllerBase(ICalendarEntityService<T> eventService)
        {
            _entityService = eventService;
        }

        [HttpGet("GetAll")]
        public async Task<IEnumerable<T>> GetAll()
        {
            return await _entityService.GetAllAsync();
        }

        [HttpGet("Get")]
        public async Task<T> Get(int id)
        {
            return await _entityService.GetByIdAsync(id);
        }

        [HttpPost("Create")]
        public async Task<IActionResult> Create([FromBody] T entity)
        {
            await _entityService.CreateAsync(entity);
            return Ok();
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update(int id, [FromBody] T entity)
        {
            await _entityService.UpdateAsync(entity);
            return Ok();
        }

        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete(int id)
        {
            await _entityService.DeleteAsync(id);
            return Ok();
        }
    }
}
