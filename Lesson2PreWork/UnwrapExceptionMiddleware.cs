using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Lesson2PreWork
{
    public class UnwrapExceptionMiddleware
    {
        private readonly RequestDelegate next;

        public UnwrapExceptionMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            await next(context);
        }
    }
}
