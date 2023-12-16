namespace Notificator.Models;

public record MediaObjectInfo
{
    public MediaObjectInfo(string name, string url)
    {
        Name = name;
        Url = url;
    }

    public string Name { get; init; }
    public string Url { get; init; }
}