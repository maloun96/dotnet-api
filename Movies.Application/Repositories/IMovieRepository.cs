using Movies.Application.Models;

namespace Movies.Application.Repositories;

public interface IMovieRepository
{
    Task<bool> CreateAsync(Movie movie);

    Task<Movie?> GetAsync(Guid id);
    
    Task<Movie?> GetBySlug(string id);

    Task<IEnumerable<Movie>> GetAllAsync();

    Task<bool> UpdateAsync(Movie movie);

    Task<bool> DeleteAsync(Guid id);
    
    Task<bool> ExistsById(Guid id);
}