using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace BuberApi.api.Controller
{
    public class ErrorsController : ControllerBase
    {

        [Route("/error")]
        public IActionResult ErrorRoute()
        {
            var exceptionError = HttpContext.Features.Get<IExceptionHandlerFeature>();
            
            return Problem();
        }
    }
}