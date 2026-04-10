using Microsoft.AspNetCore.Mvc;
using StudentManagementAPI.Helpers;

namespace StudentManagementAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IConfiguration _config;

        public AuthController(IConfiguration config)
        {
            _config = config;
        }

        [HttpPost("login")]
        public IActionResult Login(string username, string password)
        {
            if (username == "admin" && password == "admin")
            {
                var token = JwtHelper.GenerateToken(username, _config["Jwt:Key"]);
                Response.Cookies.Append("jwt", token, new CookieOptions
                {
                    HttpOnly = true,
                    Secure = false,
                    SameSite = SameSiteMode.Lax,
                    Expires = DateTime.UtcNow.AddHours(1)
                });
                return Ok(new { Token = token });
            }

            return Unauthorized();
        }
    }
}