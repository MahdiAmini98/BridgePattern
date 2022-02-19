using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BridgePattern.Example_2.Bridge.MailService.Dto;
using BridgePattern.Example_2.Bridge.MailService.Implementations;
using BridgePattern.Example_2.Bridge.MailService.Implementors;

namespace BridgePattern.Example_2.Bridge.MailService.Abstractions
{
    public abstract class MailServiceAbstraction
    {
        private IMailServiceImplementor _implementor;

        protected MailServiceAbstraction()
        {
            _implementor = Implementation.GetImplementor();
        }
        public virtual void Send(EmailInformationDto email)
        {
           _implementor.SendEmail(email.Reciver,email.Title,email.Message);
        }


    }

    public class RefinedMailService: MailServiceAbstraction
    {
        
    }

}
