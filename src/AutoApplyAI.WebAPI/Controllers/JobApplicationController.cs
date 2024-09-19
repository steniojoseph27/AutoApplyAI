using AutoApplyAI.Application.DTOs;
using AutoApplyAI.Application.Interfaces; 
using Microsoft.AspNetCore.Mvc; 
namespace AutoApplyAI.WebAPI.Controllers 
{ 
    [Route("api/[controller]")] [ApiController] 
    public class JobApplicationController : ControllerBase 
    {
        private readonly IJobApplicationService _jobApplicationService;

        public JobApplicationController(IJobApplicationService jobApplicationService)
        {
            _jobApplicationService = jobApplicationService;
        }

        [HttpPost]
        public IActionResult ApplyToJob([FromBody] JobOfferDto jobOfferDto, string candidateSkills)
        {
            var applied = _jobApplicationService.ApplyToJob(jobOfferDto, candidateSkills);
            if (applied)
            {
                return Ok("Job application submitted.");
            }
            return BadRequest("Job not relevant to your skills.");
        }
    } 
}
