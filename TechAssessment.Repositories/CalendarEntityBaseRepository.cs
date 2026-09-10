using Microsoft.EntityFrameworkCore;
using TechAssessment.Repositories.DbContexts;
using TechAssessment.Repositories.Interfaces;

namespace TechAssessment.Repositories
{
    public class CalendarEntityBaseRepository<T> : ICalendarEntityRepository<T>
        where T : class
    {
        protected readonly CalendarDbContext _dbContext;

        public CalendarEntityBaseRepository(CalendarDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddAsync(T? entity)
        {
            await _dbContext.Set<T>().AddAsync(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            await _dbContext.Set<T>().FindAsync(entity);
            await _dbContext.SaveChangesAsync();
        }

        public virtual async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbContext.Set<T>().ToListAsync();
        }

        public virtual async Task<T> GetByIdAsync(int id)
        {
            return await _dbContext.Set<T>().FindAsync(id);
        }

        public async Task UpdateAsync(T? entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }
    }
}
