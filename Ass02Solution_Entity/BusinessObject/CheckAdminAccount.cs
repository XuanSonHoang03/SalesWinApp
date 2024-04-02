using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class CheckAdminAccount
    {
        public static bool checkAdminAccount(string username, string password)
        {
            IConfigurationRoot configurationRoot = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            string email = configurationRoot["admin:username"];
            string pass = configurationRoot["admin:password"];

            if (username == email && password == pass)
            {
                return true;
            }
            return false;
        }
    }
}
