using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace SchoolAPI.Filters
{
    [AttributeUsage(AttributeTargets.Method)]
    public class CustomExceptionFilterAttribute : Attribute, IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            var contentResult = new ContentResult()
            {
                Content = context.Exception.Message,
                ContentType = "text/plain"
            };

            context.Result = contentResult;
        }
    }
}
