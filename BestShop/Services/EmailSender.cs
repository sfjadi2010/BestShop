using SendGrid;
using SendGrid.Helpers.Mail;

namespace BestShop.Services;

public class EmailSender
{
    public async static Task SendEmail(string email, string username, string subject, string message)
    {
        var apiKey = "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";

        var client = new SendGridClient(apiKey);

        var from = new EmailAddress("sfjadi@gmail.com", "BestShop");
        var to = new EmailAddress(email, username);
        var plainTextContent = message;
        var htmlContent = string.Empty;

        var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);

        await client.SendEmailAsync(msg);
    }
}
