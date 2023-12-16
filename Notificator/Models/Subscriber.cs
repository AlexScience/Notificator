namespace Notificator.Models;

public record Subscriber
{
    public Subscriber(string name, string email, List<Channel> channels)
    {
        Name = name;
        Email = email;
        Id = Guid.NewGuid();
    }

    public Subscriber()
    {
        
    }

    public Guid Id { get; }
    public string Name { get; init; }
    public string Email { get; init; }
    
    
}