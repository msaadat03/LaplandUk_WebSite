using Back_end.Services.Interfaces;
using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.Extensions.Configuration;
using MimeKit;
using MimeKit.Text;

namespace Back_end.Services
{
    public class EmailService : IEmailService
    {
        private readonly IConfiguration Configuration;

        public EmailService(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void Send(string to, string subject, string body, string from = null)
        {
            var email = new MimeMessage();

            email.From.Add(MailboxAddress.Parse(from ?? Configuration.GetSection("Smtp:FromAddress").Value));
            email.To.Add(MailboxAddress.Parse(to));
            email.Subject = subject;
            email.Body = new TextPart(TextFormat.Html) { Text = body };

            var a = Configuration.GetSection("Smtp:Server").Value;
            var b = int.Parse(Configuration.GetSection("Smtp:Port").Value);
            var c = Configuration.GetSection("Smtp:FromAddress").Value;
            var d = Configuration.GetSection("Smtp:Password").Value;

            using (var smtp = new SmtpClient())
            {
                smtp.Connect(Configuration.GetSection("Smtp:Server").Value, int.Parse(Configuration.GetSection("Smtp:Port").Value), SecureSocketOptions.StartTls);
                smtp.Authenticate(Configuration.GetSection("Smtp:FromAddress").Value, Configuration.GetSection("Smtp:Password").Value);
                smtp.Send(email);
                smtp.Disconnect(true);
            }
        }
    }
}