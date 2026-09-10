using System;
using System.Collections.Generic;
using System.Text;

namespace TechAssessment.Services.Interfaces
{
    public interface ICalendarEntityService<T>
    {
        Task CreateAsync(T? entity);
        Task DeleteAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task UpdateAsync(int id, T? entity);
    }
}
