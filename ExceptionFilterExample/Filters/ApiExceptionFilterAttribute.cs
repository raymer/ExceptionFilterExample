using System.Net.Http;
using System.Web.Http.Filters;
using ExceptionFilterExample.Core.Exceptions;
using ExceptionFilterExample.Extensions;

namespace ExceptionFilterExample.Filters
{
    public class ApiExceptionFilterAttribute : System.Web.Http.Filters.ExceptionFilterAttribute
    {
        public override void OnException(HttpActionExecutedContext context)
        {
            var exception = context.Exception as ApiException;
            if (exception != null)
            {
                context.Response = context.Request.CreateResponse(exception.StatusCode, exception.Message.ToRequestErrorModel());
            }
        }
    }
}