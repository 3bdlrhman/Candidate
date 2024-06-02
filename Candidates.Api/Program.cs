using Candidates.Api.Data;
using Candidates.Api.Data.DTOs;
using Candidates.Api.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

var cs = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(op => op.UseSqlServer(cs));
builder.Services.AddScoped<ICandidateRepository, EfCandidateRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();
app.UseAuthorization();

// Minimal-API
// POST /candidates

app.MapPost("/candidates", 
async (CandidateDto candidate, ICandidateRepository repository) =>
{
    await repository.AddOrUpdateAsync(candidate);
    return Results.Ok();
});

app.Run();
