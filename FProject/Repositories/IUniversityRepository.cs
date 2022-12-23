using FinalProject.Models;
using System.Linq.Expressions;

namespace FProject.Repositories
{
    public interface IUniversityRepository
    {
        Task<University> GetByIdAsync(int id);
        Task<List<University>> GetAllAsync();
        void Update(University university);
        Task AddAsync(University university);

        Task<List<University>> GetWithFilterAsync(Expression<Func<Student, bool>> expression = null);
        Task SaveAsync();
    }
}
