using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;

namespace TaskManager.Auth.Controllers
{
    [ApiController]
    public class AuthController : ControllerBase
    {
        [HttpPost]
        [Route("/api/login")]
        public async Task<ActionResult> Login([FromBody] LoginRequest request)
        {
            return Ok(request);
        }

        [HttpPost]
        [Route("/api/logout")]
        public async Task<ActionResult> Logout()
        {
            Response.Cookies.Delete("JwtToken");

            return Ok();
        }
    }
}
