using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAO
{
    public class AdminAccount
    {
        public static bool checkAdmin(string username, string password)
        {
            IConfigurationRoot configurationRoot = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            string adminUsername = configurationRoot["admin:email"];
            string adminPassword = configurationRoot["admin:password"];
            if (username == adminUsername && password == adminPassword)
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}
