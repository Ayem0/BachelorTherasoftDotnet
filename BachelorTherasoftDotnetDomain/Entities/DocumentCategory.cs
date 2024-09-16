using System;
using BachelorTherasoftDotnetDomain.Classes;

namespace BachelorTherasoftDotnetDomain.Entities;

public class DocumentCategory : DefaultFields
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public required string Name { get; set; }
    public required string WorkspaceId { get; set; }

    public List<Document> Documents { get; set; } = [];
}
