using DecoderWebServer.Server.Model;
using Microsoft.AspNetCore.Mvc;

namespace DecoderWebServer.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DecoderController : ControllerBase
    {
        private readonly ILogger<DecoderController> _logger;

        public DecoderController(ILogger<DecoderController> logger)
        {
            _logger = logger;
        }

        [HttpPost(Name = "")]
        public DecoderResponse Post()
        {
            throw new NotImplementedException();
        }
    }
}
