using BachelorTherasoftDotnetDomain.Classes;

namespace BachelorTherasoftDotnetDomain.Entities;

public class TaskCategory : DefaultFields
{
    public string Id = Guid.NewGuid().ToString();
    public required string WorkspaceId { get; set; }
    public required string Name { get; set; }
    public List<string> ?Icons { get; set; }

    public TaskCategory(string name) {
        Name = name;
    }

    public TaskCategory(string name, List<string> icons) {
        Name = name;
        Icons = icons;
    }
}


