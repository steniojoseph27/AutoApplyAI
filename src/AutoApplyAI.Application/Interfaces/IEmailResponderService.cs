namespace AutoApplyAI.Application.Interfaces 
{ 
    public interface IEmailResponderService 
    {
        Task SendEmailResponseAsync(string recipientEmail, string subject, string messageBody);
    } 
}
