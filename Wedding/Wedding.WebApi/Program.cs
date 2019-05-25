using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace Bys.Hbc.WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseKestrel()
                .UseUrls("http://localhost:9004")
                .UseStartup<Startup>()
                .UseIISIntegration()
                .Build();
    }
}