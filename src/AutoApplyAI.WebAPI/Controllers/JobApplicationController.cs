using AutoApplyAI.Application.Interfaces; 
using Microsoft.AspNetCore.Mvc; 
namespace AutoApplyAI.WebAPI.Controllers 
{ 
    [Route("api/[controller]")] [ApiController] 
    public class JobApplicationController : ControllerBase 
    { 
        private readonly IJobApplicationService _service; 
        public JobApplicationController(IJobApplicationService service) 
        { 
            _service = service; 
        } 
        [HttpPost] 
        public IActionResult Apply() 
        { 
            return Ok(); 
        } 
    } 
}
