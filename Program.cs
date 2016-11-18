using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace PivotalCF
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var config = new ConfigurationBuilder().AddCommandLine(args)
      .Build();

            var host = new WebHostBuilder()
                // .UseUrls("http://0.0.0.0:5000/")
                .UseKestrel()
                  .UseConfiguration(config)
                //.UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .Build();

            host.Run();
        }
    }
}
