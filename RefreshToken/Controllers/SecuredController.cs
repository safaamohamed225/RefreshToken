using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RefreshToken.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class SecuredController : ControllerBase
    {

        [HttpGet]
        public IActionResult GetSecuredData()
        {
            var userName = User.Identity?.Name;
            return Ok(new { Message = $"Hello, {userName}. This is secured data." });
        }
    }
}
