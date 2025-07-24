<<<<<<< HEAD
﻿using Microsoft.AspNetCore.Mvc;
=======
﻿//Authentication_controller

using Microsoft.AspNetCore.Mvc;
>>>>>>> 087d119 (commit message)
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Runtime.InteropServices;
using System.Security.Claims;
using System.Text;

namespace JwtAuthApi.Controllers;

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
    public IActionResult Login([FromBody] LoginRequest request)
    {
        if (request.Username == "admin" && request.Password == "password")
        {
            var claims = new[]
            {
                new Claim(ClaimTypes.Name, request.Username),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("this_is_my_custom_secure_key_for_jwt_token_generation"));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: "jwt-api",
                audience: "jwt-api-client",
                claims: claims,
                expires: DateTime.Now.AddMinutes(30),
                signingCredentials: creds);

            return Ok(new { token = new JwtSecurityTokenHandler().WriteToken(token) });
        }

        return Unauthorized();
    }
}

public class LoginRequest
{
    public string Username { get; set; }
    public string Password { get; set; }



}