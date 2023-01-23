using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Identity.UI.Services;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abby.Utility
{
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            var emailToSend = new MimeMessage();
			emailToSend.From.Add(MailboxAddress.Parse("info@nestorsystems.com"));
            emailToSend.To.Add(MailboxAddress.Parse(email));
            emailToSend.Subject = subject;
            emailToSend.Body = new TextPart(MimeKit.Text.TextFormat.Html) { Text= htmlMessage };

            using (var emailClient = new SmtpClient())
            {
                emailClient.Connect("mail.keystroke.ca", 366, MailKit.Security.SecureSocketOptions.StartTls);
                emailClient.Authenticate("info@nestorsystems.com", "sch%TGPFy_G^s^R9");
                emailClient.Send(emailToSend);
                emailClient.Disconnect(true);
            }

            return Task.CompletedTask;
        }
    }
}
