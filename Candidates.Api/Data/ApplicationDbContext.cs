using Candidates.Api.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Candidates.Api.Data
{
    public class ApplicationDbContext(DbContextOptions options) : DbContext(options)
    {
        public DbSet<Candidate> Candidates { get; set; }
    }
}
