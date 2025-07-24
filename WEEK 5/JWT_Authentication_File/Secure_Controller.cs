<<<<<<< HEAD
﻿using Microsoft.AspNetCore.Authorization;
=======
﻿//Secure_controller

using Microsoft.AspNetCore.Authorization;
>>>>>>> 087d119 (commit message)
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;

namespace JwtAuthApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SecureController : ControllerBase
{
    [Authorize]
    [HttpGet("data")]
    public IActionResult GetSecretData()
    {
        return Ok("This is protected data accessible only with a valid JWT.");
    }
}
