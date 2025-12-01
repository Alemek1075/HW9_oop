using System;

class Email
{
    public String Theme { get; set; }
    public String From { get; set; }
    public String To { get; set; }
}

// Абстракція для логування
interface ILogger
{
    void Log(string message);
}

// Конкретна реалізація логування
class ConsoleLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine(message);
    }
}

class EmailSender
{
    private readonly ILogger _logger;

    // Dependency Injection
    public EmailSender(ILogger logger)
    {
        _logger = logger;
    }

    public void Send(Email email)
    {
        // ... sending logic ...
        _logger.Log($"Email from '{email.From}' to '{email.To}' was sent");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Email e1 = new Email() { From = "Me", To = "Vasya", Theme = "Who are you?" };
        // ... інші email ...

        // Використання
        ILogger logger = new ConsoleLogger();
        EmailSender es = new EmailSender(logger);
        es.Send(e1);

        Console.ReadKey();
    }
}