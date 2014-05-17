using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Mail
{
    public class GmailSender : ISendMail
    {
        public bool Send(string[] addresses, string subject, string body)
        {
            bool result = true;

            var fromAddress = new MailAddress("tc2013course@gmail.com", "Tech Career system");
            // var toAddress = new MailAddress("to@example.com", "To Name");
            const string fromPassword = "110220330";

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential("tc2013course@gmail.com", fromPassword)
            };

            MailMessage mail = new MailMessage();
            mail.From = fromAddress;
            foreach (string address in addresses)
                mail.To.Add(address);
            mail.IsBodyHtml = true;
            mail.Subject = subject;
            mail.Body = body;

            try
            {
                smtp.Send(mail);
            }
            catch (Exception ex)
            {
                result = false;
            }

            return result;
        }
    }
}
