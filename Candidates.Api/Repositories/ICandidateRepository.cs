using Candidates.Api.Data.DTOs;

namespace Candidates.Api.Repositories
{
    // The abstraction repesenting data access operations
    public interface ICandidateRepository
    {
        Task AddOrUpdateAsync(CandidateDto candidate);
    }
}
