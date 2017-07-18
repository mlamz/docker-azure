using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace docker_azure
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseKestrel()
				.Configure(app => app.Run(context =>
				{
					return context.Response.WriteAsync($"Hello, Universe! It is {DateTime.Now}");
				}))
				.Build();

			host.Run();
        }
    }
}
