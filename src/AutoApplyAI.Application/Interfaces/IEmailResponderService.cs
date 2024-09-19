namespace AutoApplyAI.Application.Interfaces 
{ 
    public interface IEmailResponderService 
    {
        public Task SendEmailResponseAsync(string recipientEmail, string subject, string messageBody);
    } 
}
