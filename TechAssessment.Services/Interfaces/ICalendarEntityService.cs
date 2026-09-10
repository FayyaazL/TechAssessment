namespace TechAssessment.Services.Interfaces
{
    public interface ICalendarEntityService<T>
    {
        Task CreateAsync(T? entity);
        Task DeleteAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task UpdateAsync(T? entity);
    }
}
