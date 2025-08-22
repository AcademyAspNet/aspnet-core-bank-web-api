using _BankWebAPI.Data;

namespace _BankWebAPI.Middleware
{
    public class ApiKeyValidationMiddleware
    {
        private readonly RequestDelegate _next;
        private const string validApiKey = "bank-api";

        public ApiKeyValidationMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext httpContext, ApplicationDbContext database)
        {
            string? apiKey = httpContext.Request.Headers["X-API-Key"];

            if (string.IsNullOrEmpty(apiKey) || apiKey != validApiKey)
            {
                httpContext.Response.StatusCode = StatusCodes.Status401Unauthorized;
                await httpContext.Response.WriteAsync("Invalid API key!");

                return;
            }

            await _next(httpContext);
        }
    }

    public static class ApiKeyValidationExtensions
    {
        public static IApplicationBuilder UseApiKeyValidation(this IApplicationBuilder builder)
        {
            builder.UseMiddleware<ApiKeyValidationMiddleware>();
            return builder;
        }
    }
}
