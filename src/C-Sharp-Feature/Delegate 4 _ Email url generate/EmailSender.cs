using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_4___Email_url_generate
{
    internal class EmailSender
    {
        public delegate string HyperLinkGeneratorDel(int c, string e);
        public void SendBulkEmail(int campaignId, List<string> emails, HyperLinkGeneratorDel hyperLinkGenerator)
        {
            StringBuilder htmlWithLink = new StringBuilder();
            foreach (var email in emails)
            {
                htmlWithLink.Append("<html><head></head><body>");
                htmlWithLink.Append("<a href='").Append(hyperLinkGenerator(campaignId, email));
                htmlWithLink.Append("'></body></html>\n");
            } 
            Console.WriteLine(htmlWithLink);
        }
    }
}
