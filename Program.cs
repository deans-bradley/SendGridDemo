using System.Net;
using SendGrid;
using SendGrid.Helpers.Mail;
using DotNetEnv;

namespace SendGridDemo
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Env.Load();
            Console.WriteLine("Welcome! Press any key to send an email.");
            Console.ReadLine();

            Email email = new Email
            {
                From = "FROM_EMAIL_ADDRESS",
                FromName = "FROM_NAME",
                To = "TO_EMAIL_ADDRESS",
                ToName = "TO_NAME",
                Subject = "Howzit!",
                Body = "How are you doing today?"
            };

            HttpStatusCode statusCode = await Execute(email);
            
            if (statusCode == HttpStatusCode.Accepted)
            {
                Console.WriteLine("Email sent successfully!");
            }
            else
            {
                Console.WriteLine("Email failed to send.");
            }
        }

        static async Task<HttpStatusCode> Execute(Email email)
        {
            string? apiKey = Environment.GetEnvironmentVariable("SEND_GRID_API_KEY");
            SendGridClient client = new SendGridClient(apiKey);

            EmailAddress from = new EmailAddress(email.From, email.FromName);
            EmailAddress to = new EmailAddress(email.To, email.ToName);
            string htmlContent = $"<strong>{email.Body}</strong>";

            SendGridMessage msg = MailHelper.CreateSingleEmail(from, to, email.Subject, email.Body, htmlContent);
            Response response = await client.SendEmailAsync(msg);

            return response.StatusCode;
        }
    }
}