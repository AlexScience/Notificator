namespace Notificator.Models;

public record Channel
{
    public Channel(string address, string name)
    {
        Address = address;
        Name = name;
    }

    public Channel()
    {
        
    }
    public string Address { get; init; }
    public string Name { get; init; }
}