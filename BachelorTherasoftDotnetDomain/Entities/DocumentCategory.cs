using System;

namespace BachelorTherasoftDotnetDomain.Entities;

public class DocumentCategory
{
    public string Id = Guid.NewGuid().ToString();
    public required string Name { get; set; }
    public required string WorkspaceId { get; set; }
}
