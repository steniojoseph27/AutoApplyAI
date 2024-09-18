using AutoApplyAI.Application.Interfaces; 
using Microsoft.AspNetCore.Mvc; 
namespace AutoApplyAI.WebAPI.Controllers 
{ 
    [Route("api/[controller]")] [ApiController] 
    public class EmailResponderController : ControllerBase 
    { 
        private readonly IEmailResponderService _service; 
        public EmailResponderController(IEmailResponderService service) 
        { 
            _service = service; 
        } 
        
        [HttpPost] 
        public IActionResult Respond() 
        { 
            return Ok(); 
        } 
    } 
}
