namespace AutoApplyAI.Domain.Entities 
{ 
    public class EmailResponse 
    { 
        public int Id { get; set; } 
        public string Sender { get; set; } 
        public string Subject { get; set; } 
        public string Body { get; set; } 
        public DateTime DateReceived { get; set; } 
    } 
}
