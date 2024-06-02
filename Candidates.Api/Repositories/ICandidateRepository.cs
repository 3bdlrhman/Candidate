using Candidates.Api.Data.DTOs;

namespace Candidates.Api.Repositories
{
    // The abstraction representing data access operations
    public interface ICandidateRepository
    {
        Task AddOrUpdateAsync(CandidateDto candidate);
    }
}
