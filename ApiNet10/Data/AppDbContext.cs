using DefaultNamespace;
using Microsoft.EntityFrameworkCore;

namespace ApiNet10.Data;

public class AppDbContext: DbContext
{
    public DbSet<User> Users => Set<User>();

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) { }
}