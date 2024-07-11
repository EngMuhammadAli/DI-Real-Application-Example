using DI_Real_Application_Example.Service;

namespace DI_Real_Application_Example.DI_Service
{
    public class DIEmailService : IDIEmailService
    {
        public string SendEmail(string to, string subject, string body)
        {
            // Simulate sending an email
            return $"Email sent to {to} with subject {subject}{body}";
        }
    }

}
