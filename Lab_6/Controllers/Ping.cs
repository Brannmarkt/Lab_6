using Microsoft.AspNetCore.Mvc;

namespace Lab_6.Controllers
{
    [Route("/api/[controller]")]
    public class PingController : ControllerBase
    {
        [HttpGet]
        public IActionResult Ping()
        {
            return Ok(new { msg = "pong" });
        }
    }
}
