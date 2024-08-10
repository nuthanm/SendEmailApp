
using EmailApp.Application.EmailContracts;
using EmailApp.Application.Models;
using EmailApp.Infrastructure;

// Object Initiation
IEmailService emailService = new EmailService();

// Sending an email
await emailService.SendEmailAsync(
    new EmailMessage
    {
        To = "testUser@gmail.com",
        Subject = "Sending via c# using SMTP Server",
        Body = " Welcome to our world!!!"
    });