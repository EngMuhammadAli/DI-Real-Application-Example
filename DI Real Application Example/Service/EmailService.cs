namespace DI_Real_Application_Example.Service
{
    public class EmailService
    {
        public string SendEmail(string to, string subject, string body)
        {
            // Simulate sending an email
            return $"Email sent to {to} with subject {subject}";
        }
    }

}
