namespace AutoApplyAI.Domain.Entities 
{ 
    public class JobApplication 
    { 
        public int Id { get; set; } 
        public string JobTitle { get; set; } 
        public string CompanyName { get; set; } 
        public string Skills { get; set; } 
        public DateTime DateApplied { get; set; } 
    } 
}
