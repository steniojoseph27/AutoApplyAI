using AutoApplyAI.Domain.Entities;

namespace AutoApplyAI.Domain.Interfaces 
{ 
    public interface IJobApplicationRepository 
    { 
        public void Add(JobApplication jobApplication); 
        public JobApplication GetById(int id); 
    } 
}
