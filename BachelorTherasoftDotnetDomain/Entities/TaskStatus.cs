using BachelorTherasoftDotnetDomain.Classes;

namespace BachelorTherasoftDotnetDomain.Entities;

internal class TaskStatus : DefaultFields
{
    public string Id = Guid.NewGuid().ToString();
    public required string WorkspaceId { get; set; }
    public required string Name { get; set; }
    public required string Icon { get; set; }
}
