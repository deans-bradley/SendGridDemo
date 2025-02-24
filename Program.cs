using SendGrid;
using SendGrid.Helpers.Mail;

namespace SendGridDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Execute().Wait();
        }

        static async Task Execute()
        {
            string? apiKey = Environment.GetEnvironmentVariable("QR_CODE_GENERATOR_DEMO_SEND_GRID_API_KEY");
            SendGridClient client = new SendGridClient(apiKey);
            EmailAddress from = new EmailAddress("developer@deansbrad.com", "Bradley Deans");
            string subject = "SendGrid Demo.";
            EmailAddress to = new EmailAddress("bradley.deans@firsttech.digital", "Bradley Deans");
            string plainTextContent = "Howzit, my bru!";
            string htmlContent = "<strong>Howzit, my bru!</strong>";
            SendGridMessage msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
            Response response = await client.SendEmailAsync(msg);
            Console.WriteLine(response.StatusCode);
        }
    }
}