using Candidates.Api.Data;
using Candidates.Api.Data.DTOs;
using Candidates.Api.Utilities;

using Microsoft.EntityFrameworkCore;

namespace Candidates.Api.Repositories
{
    // Implementing the Data access interface using entity framework
    // Here we are using the primary constructor (pretty cool)
    public class EfCandidateRepository(ApplicationDbContext dbContext) : ICandidateRepository
    {
        private readonly ApplicationDbContext _dbContext = dbContext;

        /// <summary>
        /// This method asynchronously update an existing record (Candidate)
        /// Or adds a new record if not found
        /// </summary>
        /// <param name="candidate">DTO that either be saved or updated</param>
        /// <returns></returns>
        public async Task AddOrUpdateAsync(CandidateDto candidate)
        {
            var existingCandidate = await _dbContext.Candidates
                                              .FirstOrDefaultAsync(c => c.Email == candidate.Email);
            if (existingCandidate != null)
            {
                // Update existing candidate
                _dbContext.Entry(existingCandidate).CurrentValues.SetValues(candidate);
            }
            else
            {
                // Add new candidate
                _dbContext.Candidates.Add(candidate.AsCandidate());
            }

            await _dbContext.SaveChangesAsync();
        }
    }
}
