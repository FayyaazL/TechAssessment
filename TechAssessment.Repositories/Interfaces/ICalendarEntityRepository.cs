using TechAssessment.Core.Entities;

namespace TechAssessment.Repositories.Interfaces
{
    public interface ICalendarEntityRepository<T>
    {
        Task AddAsync(Attendee? entity);
        Task DeleteAsync(Attendee attendee);
        Task<IEnumerable<Attendee>> GetAllAsync();
        Task<Attendee> GetByIdAsync(int id);
        Task UpdateAsync(Attendee attendee, Attendee? entity);
    }
}
