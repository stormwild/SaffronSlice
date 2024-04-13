using Microsoft.EntityFrameworkCore;

using SaffronSlice.Infrastructure.Persistence;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlite(builder.Configuration.GetConnectionString("Default")));


var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();

