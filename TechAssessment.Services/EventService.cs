using TechAssessment.Core.Entities;
using TechAssessment.Services.Interfaces;

namespace TechAssessment.Services
{
    public class EventService : IEnitityService<Event>
    {
        public Task CreateAsync(Event? entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Event>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Event> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(int id, Event? entity)
        {
            throw new NotImplementedException();
        }
    }
}
