using efapi.Entities;
using Microsoft.EntityFrameworkCore;

namespace efapi.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
        
    }
    
    public DbSet<VideoGame> VideoGames { get; set; }
}
