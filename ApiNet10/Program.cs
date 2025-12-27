using ApiNet10.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// EF Core 10 pipeline optimizations
builder.Services.ConfigureHttpJsonOptions(o =>
{
    o.SerializerOptions.AllowOutOfOrderMetadataProperties = true;
});
// Read connection string from appsettings
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// Register DbContext
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseNpgsql(connectionString);
});

var app = builder.Build();


app.MapGet("/users/{orgId:int}",
    static async (int orgId, AppDbContext db) =>
        await db.Users
            .AsNoTracking()
            .Where(u => u.OrganizationId == orgId)
            .Select(u => new { u.Id, u.Name })
            .ToListAsync()
);

app.Run();
