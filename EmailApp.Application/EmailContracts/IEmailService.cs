using EmailApp.Application.Models;

namespace EmailApp.Application.EmailContracts;

public interface IEmailService
{
    Task<bool> SendEmailAsync(EmailMessage emailMessage);
}
