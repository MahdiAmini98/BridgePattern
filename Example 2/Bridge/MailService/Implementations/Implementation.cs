using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BridgePattern.Example_2.Bridge.MailService.Implementors;

namespace BridgePattern.Example_2.Bridge.MailService.Implementations
{
    public static class Implementation
    {
        public static IMailServiceImplementor GetImplementor()
        {
            var configuration = ConfigurationManager.AppSettings;

            if (configuration["EmailImplementor"]=="Gmail")
            {
                return new GmailServiceImplementor();
            }
            else if (configuration["EmailImplementor"] == "Yahoo")
            {
                return new YahooServiceImplementor();
            }
            else
            {
                return new MyCompanyServiceImplementor();
            }
           
        }
    }
}
