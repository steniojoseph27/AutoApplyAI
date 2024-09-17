using AutoApplyAI.Domain.Entities;

namespace AutoApplyAI.Domain.Interfaces 
{ 
    public interface IEmailResponseRepository 
    { 
        public void Add(EmailResponse emailResponse); 
        public EmailResponse GetById(int id); 
    } 
}
