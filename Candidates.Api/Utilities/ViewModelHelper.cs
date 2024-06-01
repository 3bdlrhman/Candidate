using Candidates.Api.Data.DTOs;
using Candidates.Api.Data.Models;

namespace Candidates.Api.Utilities
{
    public static class ViewModelHelper
    {
        // Extension Method
        // That extends the type CandidateDto allowing to cast back to the Candidate Model
        public static Candidate AsCandidate(this CandidateDto dto)
        {
            return new Candidate
            {
                BestCallTime = dto.BestCallTime,
                Comment = dto.Comment,
                Email = dto.Email,
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                GitHubProfile = dto.GitHubProfile,
                LinkedInProfile = dto.LinkedInProfile,
                PhoneNumber = dto.PhoneNumber
            };
        }
    }
}
