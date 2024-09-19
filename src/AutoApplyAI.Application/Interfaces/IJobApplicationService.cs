using AutoApplyAI.Application.DTOs;

namespace AutoApplyAI.Application.Interfaces 
{ 
    public interface IJobApplicationService 
    {
        public bool ApplyToJob(JobOfferDto jobOfferDto, string candidateSkills);
    } 
}
