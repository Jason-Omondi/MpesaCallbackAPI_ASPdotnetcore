using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MpesaCallbackAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MpesaCallbackController : ControllerBase
    {
        private readonly ILogger<MpesaCallbackController> _logger;

        public MpesaCallbackController(ILogger<MpesaCallbackController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public IActionResult HandleMpesaCallback([FromBody] MpesaCallbackData data)
        {
            try
            {
                // Validate callback data
                if (data == null)
                {
                    _logger.LogError("Invalid callback data: Null data received");
                    return BadRequest("Invalid callback data");
                }

                // Process the callback data here
                // You can access data fields like data.TransactionType, data.TransID, etc.

                // Log the received data
                _logger.LogInformation("M-Pesa callback received. Transaction ID: {TransactionID}", data.TransID);

                // Optionally, you can return a response to M-Pesa
                return Ok(new { Result = "Callback received successfully" });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while handling M-Pesa callback");
                return StatusCode(500, "An error occurred while processing the callback");
            }
        }
    }

    public class MpesaCallbackData
    {
        public string TransactionType { get; set; }
        public string TransID { get; set; }
        // Add other fields as needed
    }
}

