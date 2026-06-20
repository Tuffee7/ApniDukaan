namespace ApniDukaan.API.Middleware
{
    /// <summary>
    /// Sample class to do experiments. You can remove this class once you are done with your experiments.
    /// </summary>
    public class TestClass
    {
        public readonly RequestDelegate _next;  
        
        public TestClass(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            await _next(httpContext);
        }
    }

    public static class TestClassExtension
    {
        public static IApplicationBuilder UseTestClassMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<TestClass>();
        }
    }
}
