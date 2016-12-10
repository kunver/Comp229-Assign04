using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Comp229_Assign04
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            modellist.DataSource = Global.models;
            modellist.DataBind();
        }

        protected void addbtn_Click(object sender, EventArgs e)
        {
            //include writing and json creation

            sendemail();
        }
        protected void sendemail()
        {
            SmtpClient client = new SmtpClient();
            MailMessage message = new MailMessage();
            try
            {
                MailAddress from = new MailAddress("cc-comp229f2016@outlook.com", "from me");
                MailAddress to = new MailAddress("to@outlook.com", "to you");
                message.From = from; message.To.Add(to);
                message.Subject = "hello!";
                //just sending the basic json due to time constraints
                System.Net.Mail.Attachment attachment;
                attachment = new System.Net.Mail.Attachment("~/Assign04.json");
                message.Attachments.Add(attachment);
                client.Host = "mailserver.example.com";
                client.Credentials = new System.Net.NetworkCredential("username", "password");
                client.Send(message);


                statuslbl.Text = "message sent";

            }
            catch(Exception e)
            {
                statuslbl.Text = "message not sent";
            }
        }
    }
}