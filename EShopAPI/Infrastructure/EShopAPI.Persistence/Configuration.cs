using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace EShopAPI.Persistence
{
    public static class Configuration
    {
        public static string ConnectionString
        {
            get
            {
                ConfigurationManager configurationManager = new();
                configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(),
                    "../../Presentation/EShopAPI.API"));
                configurationManager.AddJsonFile("appsettings.json");
                return configurationManager.GetConnectionString("PostreSQL");
            }
        }
    }
}
