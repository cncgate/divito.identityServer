using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using MXP.IdentityServer.Data;

namespace MXP.IdentityServer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateWebHostBuilder(args).Build();

            SeedData.EnsureSeedData(host.Services);

            host.Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
