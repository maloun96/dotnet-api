using Movies.Application.Database;
using Movies.Application.Models;

namespace Movies.Application.Repositories;

public class MovieRepository : IMovieRepository
{
    private readonly IDbConnectionFactory _dbConnectionFactory;

    public MovieRepository(IDbConnectionFactory dbConnectionFactory)
    {
        _dbConnectionFactory = dbConnectionFactory;
    }

    public async Task<bool> CreateAsync(Movie movie)
    {
        using var connection = await _dbConnectionFactory.CreateConnectionAsync();
        using var transaction = connection.BeginTransaction();
        
    }

    public Task<Movie?> GetAsync(Guid id)
    {
       
    }

    public Task<Movie?> GetBySlug(string id)
    {
        
    }

    public Task<IEnumerable<Movie>> GetAllAsync()
    {
        
    }

    public Task<bool> UpdateAsync(Movie movie)
    {
        
    }

    public Task<bool> DeleteAsync(Guid id)
    {
        
    }

    public Task<bool> ExistsById(Guid id)
    {
        
    }
}