using AutoApplyAI.Application.DTOs;
using AutoApplyAI.Application.Interfaces;
using AutoApplyAI.Domain.Entities;
using AutoApplyAI.Domain.Interfaces;

namespace AutoApplyAI.Application.Services 
{
    public class JobApplicationService : IJobApplicationService 
    {
        private readonly IJobApplicationRepository _jobApplicationRepository;
        private readonly IJobOfferClassifierService _jobOfferClassifierService;

        public JobApplicationService(
            IJobApplicationRepository jobApplicationRepository,
            IJobOfferClassifierService jobOfferClassifierService)
        {
            _jobApplicationRepository = jobApplicationRepository;
            _jobOfferClassifierService = jobOfferClassifierService;
        }

        public bool ApplyToJob(JobOfferDto jobOfferDto, string candidateSkills)
        {
            // Map DTO to Domain Entity
            var jobOffer = new JobOffer
            {
                JobTitle = jobOfferDto.JobTitle,
                CompanyName = jobOfferDto.CompanyName,
                JobDescription = jobOfferDto.JobDescription,
                RequiredSkills = jobOfferDto.RequiredSkills
            };

            // Use ML Model service to determine if the job offer is relevant
            if (_jobOfferClassifierService.IsRelevantJob(jobOffer, candidateSkills))
            {
                // Create a new job application if relevant
                var jobApplication = new JobApplication
                {
                    JobTitle = jobOffer.JobTitle,
                    CompanyName = jobOffer.CompanyName,
                    Skills = candidateSkills,
                    DateApplied = DateTime.Now
                };

                // Save to the repository
                _jobApplicationRepository.Add(jobApplication);
                return true; // Applied to the job
            }

            return false; // Did not apply to the job
        }
    } 
}
