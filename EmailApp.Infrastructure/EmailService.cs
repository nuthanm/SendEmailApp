using EmailApp.Application.EmailContracts;
using EmailApp.Application.Models;
using System.Net.Mail;

namespace EmailApp.Infrastructure;

public class EmailService : IEmailService
{
    public Task<bool> SendEmailAsync(EmailMessage emailMessage)
    {
        // SmtpClient - Comes under System.Net.Mail namespace
        // No need to separate nuget package installation required.
        using var smtpClient = new SmtpClient();

    }
}
