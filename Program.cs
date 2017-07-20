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
					return context.Response.WriteAsync($"Continuous Integration and Deployment between Github, Docker Cloud and Azure. The date and time is {DateTime.Now}");
				}))
				.Build();

			host.Run();
        }
    }
}
