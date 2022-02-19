using System;
using BridgePattern.Example_1.Bridge.Abstractions;
using BridgePattern.Example_2.Bridge.MailService.Abstractions;
using BridgePattern.Example_2.Bridge.MailService.Dto;

namespace BridgePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Example 1

            //RefinedAbstraction abstraction = new RefinedAbstraction();

            //abstraction.Function();

            #endregion

            #region Example 2

            RefinedMailService mailService = new RefinedMailService();

            mailService.Send(new EmailInformationDto()
            {
                Message = "This is a Message From My App",
                Reciver = "Classicus.ma@gmail.com",
                Title = "Alert Mail"
            });
            #endregion
            Console.ReadKey();
        }
    }
}
