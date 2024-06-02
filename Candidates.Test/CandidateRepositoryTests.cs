using Microsoft.EntityFrameworkCore;
using Candidates.Api.Data;
using Candidates.Api.Repositories;
using Candidates.Api.Data.DTOs;

namespace Candidates.Test
{
    public class CandidateRepositoryTests
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly ICandidateRepository _candidateRepository;

        public CandidateRepositoryTests()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: "CandidateDatabase")
                .Options;

            _dbContext = new ApplicationDbContext(options);
            _candidateRepository = new EfCandidateRepository(_dbContext);
        }

        [Fact]
        public async Task AddOrUpdateAsync_AddsNewCandidate()
        {
            var userEmail = "user@email.com";

            var candidate = new CandidateDto { Email = userEmail, FirstName = "John" };

            await _candidateRepository.AddOrUpdateAsync(candidate);

            var result = await _dbContext.Candidates.FindAsync(userEmail);
            
            Assert.Equal("John", result?.FirstName);
        }

        [Fact]
        public async Task AddOrUpdateAsync_UpdatesExistingCandidate()
        {
            var userEmail = "user@email.com";

            var candidate = new CandidateDto { Email = userEmail, FirstName = "AbdoAhmed01" };
            await _candidateRepository.AddOrUpdateAsync(candidate);

            candidate.FirstName = "AbdoAhmed02";
            await _candidateRepository.AddOrUpdateAsync(candidate);

            var result = await _dbContext.Candidates.FindAsync(userEmail);
            Assert.NotNull(result);
            Assert.Equal("AbdoAhmed02", result.FirstName);
        }
    }
}
