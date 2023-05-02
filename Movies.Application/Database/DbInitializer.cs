using Dapper;

namespace Movies.Application.Database;

public class DbInitializer
{
    private readonly IDbConnectionFactory _dbConnectionFactory;

    public DbInitializer(IDbConnectionFactory dbConnectionFactory)
    {
        _dbConnectionFactory = dbConnectionFactory;
    }

    public async Task InitializeAsync()
    {
        using var connection = await _dbConnectionFactory.CreateConnectionAsync();

        await connection.ExecuteAsync("""
            create table if not exists movies (
                id int NOT NULL,
                slug TEXT not null,
                title TEXT not null,
                yearsofrelease integer not null,
                PRIMARY KEY (id),
            );
        
        """);        
        
        await connection.ExecuteAsync("""
            create table if not exists genres (
                id int NOT NULL,
                movieId int NOT NULL,
                name TEXT not null,
                PRIMARY KEY (id),
                FOREIGN KEY (movieId) REFERENCES movies(ID)
            );
        """);
    }
}