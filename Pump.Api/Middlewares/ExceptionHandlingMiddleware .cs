using System.Text.Json;
using Pump.Apllication.Validators;

namespace Pump.Api.Middlewares
{

    public class ExceptionHandlingMiddleware : IMiddleware
    {
        private readonly ILogger<ExceptionHandlingMiddleware> _logger;

        public ExceptionHandlingMiddleware(ILogger<ExceptionHandlingMiddleware> logger)
        {
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            try
            {
                await next(context);
            }
            catch (Exception e)
            {
                _logger.LogError(e, e.Message);
                await HandleExceptionAsync(context, e);
            }
        }

        private static async Task HandleExceptionAsync(HttpContext httpContext, Exception exception)
        {
            var statusCode = GetStatusCode(exception);
            var response = new
            {
                title = GetTitle(exception),
                status = statusCode,
                detail = exception.Message,
                errors = GetErrors(exception)
            };
            httpContext.Response.ContentType = "application/json";
            httpContext.Response.StatusCode = statusCode;
            await httpContext.Response.WriteAsync(JsonSerializer.Serialize(response));
        }

        private static int GetStatusCode(Exception exception) => exception switch
        {
            // BadRequestException => StatusCodes.Status400BadRequest,
            // NotFoundException => StatusCodes.Status404NotFound,
            Pump.Apllication.Validators.ValidationException => StatusCodes.Status400BadRequest,
            _ => StatusCodes.Status500InternalServerError
        };

        private static string GetTitle(Exception exception) =>
        exception switch
        {
            ApplicationException applicationException => applicationException.Message,
            _ => "Server Error"
        };

        private static IList<ValidationErrorViewModel>? GetErrors(Exception exception)
        {
            IList<ValidationErrorViewModel>? errors = null;
            if (exception is Pump.Apllication.Validators.ValidationException validationException)
            {
                errors = validationException.Errors;
            }
            return errors;
        }
    }
}