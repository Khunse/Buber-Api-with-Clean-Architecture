namespace BuberApi.api.Middlewares
{
    public class GlobalExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        public GlobalExceptionMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
               await  _next(context);
            }
            catch (Exception ex)
            {
                await HandleGlobalException(context, ex);
            }
        }

        public static Task HandleGlobalException(HttpContext context, Exception ex)
        {
            // throw new Exception("ha ha exception!!");
            return context.Response.WriteAsync("Global Exception: Error occur while processing the request!");
        }
    }
}