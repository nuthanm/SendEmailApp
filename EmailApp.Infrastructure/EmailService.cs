using EmailApp.Application.EmailContracts;
using EmailApp.Application.Models;
using Microsoft.Extensions.Options;
using System.Net;
using System.Net.Mail;

namespace EmailApp.Infrastructure;

// Class uses Primary Constructor feature which is available in C#12, .NET8
public class EmailService(IOptions<EmailConfiguration> _emailConfiguration) : IEmailService
{
    public async Task<bool> SendEmailAsync(EmailMessage _emailMessage)
    {
        // SmtpClient - Comes under System.Net.Mail namespace
        // No need to separate nugget package installation required.
        using var smtpClient = new SmtpClient();

        var mailMessage = new MailMessage()
        {
            From = new MailAddress(_emailConfiguration.Value.FromAddress, _emailConfiguration.Value.FromName),
            Subject = _emailMessage.Subject,
            Body = _emailMessage.Body,
            IsBodyHtml = true
        };

        // You can send many people: MailAddressCollection
        mailMessage.To.Add(_emailMessage.To);

        // Configure SMTP Server
        smtpClient.Host = _emailConfiguration.Value.SmtpServer;
        smtpClient.Port = _emailConfiguration.Value.SmtpPort;
        // smtpClient.UseDefaultCredentials = false;
        smtpClient.Credentials = new NetworkCredential(_emailConfiguration.Value.SmtpUsername, _emailConfiguration.Value.SmtpPassword);
        smtpClient.EnableSsl = true; // For gmail

        // Send an email
        await smtpClient.SendMailAsync(mailMessage);
        return true;
    }
}
