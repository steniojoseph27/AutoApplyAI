using System;

namespace AutoApplyAI.Application.DTOs
{
    public class JobOfferDto
    {
        public string JobTitle { get; set; } = string.Empty;
        public string CompanyName { get; set; } = string.Empty;
        public string JobDescription { get; set; } = string.Empty;
        public string RequiredSkills { get; set; } = string.Empty;
    }
}
