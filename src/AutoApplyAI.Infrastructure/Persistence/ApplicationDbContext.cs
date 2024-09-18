using Microsoft.EntityFrameworkCore; 
using AutoApplyAI.Domain.Entities; 
namespace AutoApplyAI.Infrastructure.Persistence 
{ 
    public class ApplicationDbContext : DbContext 
    { 
        public DbSet<JobApplication> JobApplications { get; set; } 
        public DbSet<EmailResponse> EmailResponses { get; set; } 
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        { 

        } 
    } 
}
