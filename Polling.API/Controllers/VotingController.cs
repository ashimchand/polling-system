using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Polling.Domain.ViewModel;
using Polling.Service.Interface;

namespace Polling.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VotingController : ControllerBase
    {
        private readonly IVotingService _votingService;
        private readonly ILogger _logger;
        public VotingController(IVotingService votingService, ILogger logger)
        {
            _votingService = votingService;
            _logger = logger;
        }

        [HttpGet("{id:guid}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            try
            {
                var voting = await _votingService.GetDataAsync(id);
                if (voting == null) return NotFound(new ApiResponse<string>(null, "Voting not found", false));
                return Ok(new ApiResponse<VotingRecord>(voting));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return StatusCode(500, new ApiResponse<string>(null, "An error occurred while fetching the voting", false));
            }

        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] VotingRecord voting)
        {
            try
            {
                await _votingService.CreateAsync(voting);
                return CreatedAtAction(nameof(GetById), new { id = Guid.NewGuid() }, new ApiResponse<string>("Voting created successfully"));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return StatusCode(500, new ApiResponse<string>(null, "An error occurred while creating the product", false));
            }
           
        }

        [HttpPut("{id:guid}")]
        public async Task<IActionResult> Update([FromBody] VotingRecord voting)
        {
            try
            {
                await _votingService.ModifyAsync(voting);
                return Ok(new ApiResponse<string>("Voting updated successfully"));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return StatusCode(500, new ApiResponse<string>(null, "An error occurred while updating the voting", false));
            }

        }

        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            try
            {
                await _votingService.DeleteAsync(id);
                return Ok(new ApiResponse<string>("Voting deleted successfully"));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return StatusCode(500, new ApiResponse<string>(null, "An error occurred while updating the voting", false));
            }
        }
    }
}
