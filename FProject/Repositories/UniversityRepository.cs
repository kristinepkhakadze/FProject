using System.Linq.Expressions;
using FinalProject;
using Microsoft.EntityFrameworkCore;
//using FProject.Models;

namespace FProject.Repositories;

public class UniversityRepository : IUniversityRepository
{
    private readonly UniversityDbContext _dbContext;

    public UniversityRepository(UniversityDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<University> GetByIdAsync(int id)
    {
        return await _dbContext.Student.Where(x => x.Id == id).FirstOrDefaultAsync();
    }

    public async Task<List<University>> GetAllAsync()
    {
        return await _dbContext.Restaurants.ToListAsync();
    }

    public void Update(University restaurant)
    {
        _dbContext.University.Update(university);
        _dbContext.Entry(university).State = EntityState.Modified;
    }

    public async Task AddAsync(University university)
    {
        await _dbContext.University.AddAsync(university);
        _dbContext.Entry(university).State = EntityState.Added;
    }

    public async Task<List<University>> GetWithFilterAsync(Expression<Func<University, bool>> expression = null)
    {
        if (expression != null)
        {
            return await _dbContext.University.Where(expression).ToListAsync();
        }

        return await _dbContext.University.ToListAsync();
    }

    public async Task SaveAsync()
    {
        await _dbContext.SaveChangesAsync();
    }
}
