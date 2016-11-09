using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using WebApplication2.Exceptions;

namespace WebApplication2.Filters
{
    public class ExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            var exception = context.Exception as ValidationException;

            if (exception == null)
                return;

            context.ModelState.AddModelError(exception.Name, exception.Message);
            context.Result = new BadRequestObjectResult(context.ModelState);
        }
    }
}
