using FinalProject.Models;
using System.Linq.Expressions;

namespace FProject.Repositories
{
    public interface IUniversityRepository
    {
        Task<Student> GetByIdAsync(int id);
        Task<List<Student>> GetAllAsync();
        void Update(Student university);
        Task AddAsync(Student university);

        Task<List<Student>> GetWithFilterAsync(Expression<Func<Student, bool>> expression = null);
        Task SaveAsync();
    }
}
