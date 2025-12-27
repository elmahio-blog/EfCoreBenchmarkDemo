using ApiNet8.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Read connection string from appsettings
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// Register DbContext
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseNpgsql(connectionString);
});

var app = builder.Build();

app.MapGet("/users/{orgId:int}", async (int orgId, AppDbContext db) =>
{
    return await db.Users
        .AsNoTracking()
        .Where(u => u.OrganizationId == orgId)
        .Select(u => new { u.Id, u.Name })
        .ToListAsync();
});

app.Run();
