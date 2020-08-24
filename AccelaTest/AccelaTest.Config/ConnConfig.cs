using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AccelaTest.Config
{
    public static class ConnConfig
    {
        private static IConfigurationRoot Configuration { get; set; }
        private static string ConnectionString  { get; set; }
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
