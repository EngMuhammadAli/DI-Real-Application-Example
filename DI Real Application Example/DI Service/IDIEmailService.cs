namespace DI_Real_Application_Example.Service
{
    public interface IDIEmailService
    {
        string SendEmail(string to, string subject, string body);

    }
}
