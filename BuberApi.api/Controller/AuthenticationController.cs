using BuberApi.Application.services.Authentication;
using BuberApi.Contracts.Authentication;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("auth")]
public class AuthenticationController : ControllerBase
{
    private readonly IAuthenticationService _authenticationService;

    public AuthenticationController(IAuthenticationService authenticationService)
    {
        _authenticationService = authenticationService;
    }

    [HttpPost("register")]
    public IActionResult Register(RegisterRequest registerRequest)
    {
        var respModel = _authenticationService.Register(registerRequest.FirstName,registerRequest.LastName,registerRequest.Email,registerRequest.Password);

        return Ok(respModel);
    }

    [HttpPost("login")]
    public IActionResult Login(LoginRequest loginRequest)
    {
        var respModel = _authenticationService.Login(loginRequest.Email,loginRequest.Password);

        return Ok(loginRequest);
    }
}