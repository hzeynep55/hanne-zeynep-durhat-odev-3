using System;
using Microsoft.AspNetCore.Mvc.Filters;

namespace proje_base.Filters
{
    public class ResponseGuidAttribute : ResultFilterAttribute
    {
        public override void OnResultExecuting(ResultExecutingContext context)
        {
            context.HttpContext.Response.Headers.Add("Response-Guid", Guid.NewGuid().ToString());
        }
    }
}
