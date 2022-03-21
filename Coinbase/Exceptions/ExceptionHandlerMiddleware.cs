using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Coinbase.Exceptions
{
    public class ExceptionHandlerMiddleware
    {
        private readonly RequestDelegate _next;

        public ExceptionHandlerMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            _next(context);
        }
    }
}