using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Lesson2PreWork
{
    public class TimingMiddleware
    {
        private readonly RequestDelegate next;

        public TimingMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var start = new Stopwatch();
            start.Start();
            await next(context);
            start.Stop();
            Console.WriteLine(start.ElapsedMilliseconds);
        }
    }
}
