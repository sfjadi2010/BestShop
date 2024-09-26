using SendGrid;
using SendGrid.Helpers.Mail;

namespace BestShop.Services;

public class EmailSender
{
    public async static Task SendEmail(string email, string username, string subject, string message)
    {
        var apiKey = "";

        var client = new SendGridClient(apiKey);

        var from = new EmailAddress("sfjadi@gmail.com", "BestShop");
        var to = new EmailAddress(email, username);
        var plainTextContent = message;
        var htmlContent = string.Empty;

        var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);

        await client.SendEmailAsync(msg);
    }
}
