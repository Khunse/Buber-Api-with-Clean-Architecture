using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace BuberApi.api.Filters
{
    public class ErrorHandlingFilter : ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context)
        {
            var exception = context.Exception;

            var value = new { error = "Filter Exception : Error occur in processing the request!"};         // plain error response object
    
            var problemDetail = new ProblemDetails()        // problem detail object for error response
            {
                Title = "Filter Exception : Error occur in processing the request!",
                Status = 500,
                Detail = "filter exception error detail!"
            };

            context.Result = new ObjectResult(problemDetail);

            context.ExceptionHandled = true;
        }
    }

}