using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace identity_test_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [Authorize]
        [HttpGet("test")]
        public IActionResult Get()
        {
            
            return Ok(new { message = "Test" });
        }
    }
}
