using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendGmailWithAttach
{
    class EmailData
    {
        private String emailAddress;
        private String attachFile;

        public EmailData(string emailAddress, string attachFile)
        {
            this.emailAddress = emailAddress;
            this.attachFile = attachFile;
        }

        public string EmailAddress { get => emailAddress; set => emailAddress = value; }
        public string AttachFile { get => attachFile; set => attachFile = value; }
    }
}
