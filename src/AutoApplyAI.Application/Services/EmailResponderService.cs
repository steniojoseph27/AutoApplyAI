using AutoApplyAI.Application.Interfaces;
using Microsoft.Extensions.Configuration;
using SendGrid;
using SendGrid.Helpers.Mail;
using System.Net.Mail;

namespace AutoApplyAI.Application.Services 
{ 
    public class EmailResponderService : IEmailResponderService 
    {
        private readonly IConfiguration _configuration;

        public EmailResponderService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task SendEmailResponseAsync(string recipientEmail, string subject, string messageBody)
        {
            var apiKey = _configuration["SendGrid:ApiKey"];
            var client = new SendGridClient(apiKey);
            var from = new EmailAddress(_configuration["SendGrid:Email"], "AutoApplyAI");
            var to = new EmailAddress(recipientEmail);
            var msg = MailHelper.CreateSingleEmail(from, to, subject, messageBody, messageBody);

            var response = await client.SendEmailAsync(msg);

            if (!response.IsSuccessStatusCode)
            {
                throw new System.Exception($"Failed to send email. Status code: {response.StatusCode}");
            }
        }
    } 
}
