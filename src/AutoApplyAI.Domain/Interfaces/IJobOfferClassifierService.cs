using AutoApplyAI.Domain.Entities;

namespace AutoApplyAI.Domain.Interfaces
{
    public interface IJobOfferClassifierService
    {
        public bool IsRelevantJob(JobOffer jobOffer, string candidateSkills);
    }
}
