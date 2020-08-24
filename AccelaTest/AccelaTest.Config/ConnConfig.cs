using Microsoft.Extensions.Configuration;
using System.IO;

namespace AccelaTest.Config
{
    public static class ConnConfig
    {
        private static IConfigurationRoot Configuration { get; set; }
        private static string ConnectionString { get; set; }

        public static string GetConnection()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .AddEnvironmentVariables();
            Configuration = builder.Build();
            ConnectionString = Configuration["ConnectionStrings:AccelaConnection"];

            return ConnectionString;
        }
    }
}