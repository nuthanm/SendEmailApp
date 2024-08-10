# SendEmailApp

In this sample code we used **SMTPClient** to send an email.

**Techincal Stack:**
- Language: C#
- Framework: .NET8

- Example code in this project, we configured **Gmail SMTP Server**
Follow these steps to configure Gmail SMTP Server before you send an email using this code.
Gmail Configuration
Important Note: For security reasons, Google recommends using App Passwords instead of regular passwords.

**Access Google Security Settings:**
- Go to [this url](https://myaccount.google.com/security)
- Turn On 2-Step Verification:
- If not already enabled, turn on 2-Step Verification.
**Generate App Password:**
- In the same Security settings, look for "App passwords."
- Click "Select app" and choose "Other (Custom name)."
- Give it a descriptive name (e.g., "C# Email App").
- Click "Generate."
- Copy the generated password.

Before you run this application, First replace the following values,
- In appsettings.json,
   - SmtpPassword: "**With your generated password**"
   - SmtpUserName: "Your email address"
- In Program.cs,
   - Change **To** with your email address.

## References
1. Alternative you can test using
   - [SendGrid](https://www.twilio.com/docs/sendgrid/for-developers/sending-email/email-api-quickstart-for-c)
   - [Smtp4Dev](https://github.com/rnwood/smtp4dev)


