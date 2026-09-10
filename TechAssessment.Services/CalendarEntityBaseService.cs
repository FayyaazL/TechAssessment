using TechAssessment.Repositories.Interfaces;
using TechAssessment.Services.Interfaces;

namespace TechAssessment.Services
{
    public class CalendarEntityBaseService<T> : ICalendarEntityService<T>
    {
        private readonly ICalendarEntityRepository<T> _repository;

        public CalendarEntityBaseService(ICalendarEntityRepository<T> repository)
        {
            _repository = repository;
        }

        public async Task CreateAsync(T? entity)
        {
            await _repository.AddAsync(entity);
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _repository.GetByIdAsync(id);
            if (entity != null)
            {
                await _repository.DeleteAsync(entity);
            }
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task UpdateAsync(T? entity)
        {
            await _repository.UpdateAsync(entity);
        }
    }
}
