using BuberApi.Contracts.Authentication;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("auth")]
public class AuthenticationController : ControllerBase
{

    [HttpPost("register")]
    public IActionResult Register(RegisterRequest registerRequest)
    {

        return Ok(registerRequest);
    }

    [HttpPost("login")]
    public IActionResult Login(LoginRequest loginRequest)
    {

        return Ok(loginRequest);
    }
}