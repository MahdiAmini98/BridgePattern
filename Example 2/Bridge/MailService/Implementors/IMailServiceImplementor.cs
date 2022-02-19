using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Example_2.Bridge.MailService.Implementors
{
    public interface IMailServiceImplementor
    {
        void SendEmail(string reciver, string title, string message);
    }

    public class GmailServiceImplementor : IMailServiceImplementor
    {
        public void SendEmail(string reciver, string title, string message)
        {
            //codes send gmail
            Console.WriteLine($"Email ---{title}--- Send to---{reciver}---with ***{nameof(GmailServiceImplementor)}***");
        }
    }

    public class YahooServiceImplementor : IMailServiceImplementor
    {
        public void SendEmail(string reciver, string title, string message)
        {
            //codes send Yahoo
            Console.WriteLine($"Email ---{title}--- Send to---{reciver}---with ***{nameof(YahooServiceImplementor)}***");
        }
    }


    public class MyCompanyServiceImplementor : IMailServiceImplementor
    {
        public void SendEmail(string reciver, string title, string message)
        {
            //codes send MyCompany
            Console.WriteLine($"Email ---{title}--- Send to---{reciver}---with ***{nameof(MyCompanyServiceImplementor)}***");
        }
    }
}
