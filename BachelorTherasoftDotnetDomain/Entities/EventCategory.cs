using BachelorTherasoftDotnetDomain.Classes;

namespace BachelorTherasoftDotnetDomain.Entities;

public class EventCategory : DefaultFields
{
    public string Id = Guid.NewGuid().ToString();
    public required string WorkspaceId { get; set; }
    public required string Name { get; set; }
    public List<string> ?Icons { get; set; }

    public EventCategory(string name) {
        Name = name;
    }

    public EventCategory(string name, List<string> icons) {
        Name = name;
        Icons = icons;
    }
}


