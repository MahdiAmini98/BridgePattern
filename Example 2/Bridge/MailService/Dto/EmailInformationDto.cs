using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Example_2.Bridge.MailService.Dto
{
    public class EmailInformationDto
    {
        public string Reciver { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }


    }
}
