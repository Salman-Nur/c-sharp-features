



//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Delegates
//{
//    public class EmailSender
//    {



//    }
//}








using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public class EmailSender
    {
        //public delegate string HyperlinkGenerator(int c, string e);
        // public void SendBulkEmail(int campaignId, List<string> emailAddress, HyperlinkGenerator hyperlinkGenerator)


        //public void SendBulkEmail(int campaignId, List<string> emailAddress, Action<int, string, string> hyperlinkGenerator) // If there is no return type of Funcion
        public void SendBulkEmail(int campaignId, List<string> emailAddress, Func<int, string, string> hyperlinkGenerator)
        {
            foreach (var email in emailAddress)
            {
                StringBuilder builder = new StringBuilder();
                builder.Append("<html><head></head><body>");

                builder.Append("<a href='").Append(hyperlinkGenerator(campaignId, email));

                builder.Append("'/></body></html>");

                //SendEmail(builder);
                Console.WriteLine(builder.ToString());
            }       


        }
    }
}
