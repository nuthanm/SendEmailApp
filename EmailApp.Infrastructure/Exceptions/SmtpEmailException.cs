namespace EmailApp.Infrastructure.Exceptions;

public class SmtpEmailException(Exception innerException, string email, string action) : Exception($"failed to send the {action} email to {email}.", innerException)
{
}
