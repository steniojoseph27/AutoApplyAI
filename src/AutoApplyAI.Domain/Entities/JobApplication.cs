namespace AutoApplyAI.Domain.Entities 
{ 
    public class JobApplication 
    { 
        public int Id { get; set; } 
        public string JobTitle { get; set; } = string.Empty;
        public string CompanyName { get; set; } = string.Empty;
        public string Skills { get; set; } = string.Empty;
        public DateTime DateApplied { get; set; }
    } 
}
