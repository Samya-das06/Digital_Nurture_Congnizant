using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace ConsoleWebApiApp.Controllers;

[ApiController]
[Route("api/[controller]")]
[ServiceFilter(typeof(LogActionFilter))]
public class ProductsController : ControllerBase
{
    // Query parameters and attribute routing
    [HttpGet("search")]
    public IActionResult Search([FromQuery] string category, [FromQuery] int page = 1)
    {
        return Ok($"Searching for Category: {category}, Page: {page}");
    }

    // Route param
    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        return Ok($"Product ID: {id}");
    }

    // JWT secured endpoint
    [Authorize]
    [HttpGet("secure")]
    public IActionResult GetSecureData()
    {
        var user = HttpContext.User.Identity?.Name;
        return Ok($"Hello {user}, this is a secure endpoint!");
    }

    // Public login to generate JWT token
    [AllowAnonymous]
    [HttpPost("login")]
    public IActionResult Login([FromQuery] string username)
    {
        var claims = new[]
        {
            new Claim(ClaimTypes.Name, username),
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
        };

        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("super-secret-key-for-jwt-demo"));
        var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

        var token = new JwtSecurityToken(
            issuer: "demo-app",
            audience: "demo-client",
            claims: claims,
            expires: DateTime.Now.AddMinutes(30),
            signingCredentials: creds);

        return Ok(new
        {
            token = new JwtSecurityTokenHandler().WriteToken(token)
        });
    }

    // Simulated SOAP service call (dummy logic for demo)
    [HttpGet("soap")]
    public IActionResult CallSoapService()
    {
        // Simulated SOAP response (replace with actual SOAP client call)
        return Ok("Simulated SOAP response: [SOAP Data]");
    }
}
