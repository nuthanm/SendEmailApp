
using EmailApp.Application.EmailContracts;
using EmailApp.Application.Models;
using EmailApp.Infrastructure.Exceptions;
using EmailApp.Infrastructure.Extensions;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var host = CreateHostBuilder(args).Build();

static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureServices((hostContext, services) =>
            {
                services.Configure<EmailConfiguration>(hostContext.Configuration.GetSection("EmailConfiguration"));
                services.AddInfrastructureServices();
            });

// Dependency injection approach (recommended for security)
using (var scope = host.Services.CreateScope())
{
    var emailService = scope.ServiceProvider.GetRequiredService<IEmailService>();

    try
    {
        // Sending an email with injected EmailConfiguration
        await emailService.SendEmailAsync(
            new EmailMessage
            {
                To = "<Add_your_to_address>",
                Subject = "Sending via c# using SMTP Server",
                Body = "Welcome to our world!"
            });
        Console.WriteLine("Email sent successfully.");
    }
    catch (Exception ex)
    {
        _ = new SmtpEmailException(ex, email: string.Empty, "Welcome mail");
    }
}