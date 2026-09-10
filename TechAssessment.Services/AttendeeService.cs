using TechAssessment.Core.Entities;
using TechAssessment.Services.Interfaces;

namespace TechAssessment.Services
{
    public class AttendeeService : IEnitityService<Attendee>
    {
        public Task CreateAsync(Attendee? entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Attendee>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Attendee> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(int id, Attendee? entity)
        {
            throw new NotImplementedException();
        }
    }
}
