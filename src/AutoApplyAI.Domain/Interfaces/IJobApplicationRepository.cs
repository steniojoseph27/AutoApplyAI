using AutoApplyAI.Domain.Entities;

namespace AutoApplyAI.Domain.Interfaces 
{ 
    public interface IJobApplicationRepository 
    { 
        void Add(JobApplication jobApplication); 
        JobApplication GetById(int id); 
    } 
}
