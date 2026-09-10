using TechAssessment.Core.Entities;
using TechAssessment.Repositories.Interfaces;
using TechAssessment.Services.Interfaces;

namespace TechAssessment.Services
{
    public class AttendeeService : ICalendarEntityService<Attendee>
    {
        private readonly ICalendarEntityRepository<Attendee> _attendeeRepository;

        public AttendeeService(ICalendarEntityRepository<Attendee> attendeeRepository)
        {
            _attendeeRepository = attendeeRepository;
        }

        public async Task CreateAsync(Attendee? entity)
        {
            await _attendeeRepository.AddAsync(entity);
        }

        public async Task DeleteAsync(int id)
        {
            var attendee = await _attendeeRepository.GetByIdAsync(id);
            if (attendee != null)
            {
                await _attendeeRepository.DeleteAsync(attendee);
            }
        }

        public async Task<IEnumerable<Attendee>> GetAllAsync()
        {
            return await _attendeeRepository.GetAllAsync();
        }

        public async Task<Attendee> GetByIdAsync(int id)
        {
            return await _attendeeRepository.GetByIdAsync(id);
        }

        public async Task UpdateAsync(int id, Attendee? entity)
        {
            var attendee = await _attendeeRepository.GetByIdAsync(id);
            if (attendee != null)
            {
                await _attendeeRepository.UpdateAsync(attendee, entity);
            }
        }
    }
}
