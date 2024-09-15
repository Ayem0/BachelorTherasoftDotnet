using BachelorTherasoftDotnetDomain.Classes;

namespace BachelorTherasoftDotnetDomain.Entities;

internal class WorkspaceRight : DefaultFields
{
    public string Id = Guid.NewGuid().ToString();
    public required string WorkspaceId { get; set; }
    public required string Name { get; set; }
}
