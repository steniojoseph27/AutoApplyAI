using AutoApplyAI.Application.Interfaces;
using AutoApplyAI.WebAPI.Request;
using Microsoft.AspNetCore.Mvc; 
namespace AutoApplyAI.WebAPI.Controllers 
{ 
    [Route("api/[controller]")] [ApiController] 
    public class EmailResponderController : ControllerBase 
    {
        private readonly IEmailResponderService _emailResponderService;
        public EmailResponderController(IEmailResponderService emailResponderService) 
        {
            _emailResponderService = emailResponderService;
        }

        [HttpPost("send")]
        public async Task<IActionResult> SendEmail([FromBody] EmailRequest request)
        {
            await _emailResponderService.SendEmailResponseAsync(request.RecipientEmail, request.Subject, request.MessageBody);
            return Ok("Email sent successfully.");
        }
    } 
}
