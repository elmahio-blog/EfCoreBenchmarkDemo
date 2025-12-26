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

/*using ApiNet8.Data;
using DefaultNamespace;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

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

app.Run();*/