using System.Net.Mail;

namespace SpeedyMailerTestingApplications
{
    class Program
    {
        static void Main(string[] args)
        {
            var message = new MailMessage("david@xomixinc.com", "davidm@delver.com");
            message.Body = "yeah";
            message.Subject = "cool";
            message.Headers.Add("Speedy-Creaive=Id", "creative/1");

            var client = new SmtpClient();
            client.Send(message);
        }
    }
}
