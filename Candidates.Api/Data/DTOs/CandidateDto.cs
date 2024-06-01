using System.ComponentModel.DataAnnotations;

namespace Candidates.Api.Data.DTOs
{
    public record CandidateDto
    {
        [Key]
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string BestCallTime { get; set; }
        public string LinkedInProfile { get; set; }
        public string GitHubProfile { get; set; }
        public string Comment { get; set; }
    }
}
