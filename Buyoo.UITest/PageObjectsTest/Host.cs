using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.Seleno.Configuration;
using TestStack.Seleno.Configuration.WebServers;

namespace Buyoo.UITest.PageObjectsTest
{
    public static class Host
    {
        public static readonly SelenoHost Instance = new SelenoHost();

        static Host()
        {
            Instance.Run(configure => configure
            .WithWebServer(new InternetWebServer("http://www.buyoo.com")));
        }
    }
}
