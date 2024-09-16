using System;
using BachelorTherasoftDotnetDomain.Classes;

namespace BachelorTherasoftDotnetDomain.Entities;

public class Document : DefaultFields
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public required string EventId { get; set; }
    public required Event Event { get; set; }
    public List<DocumentCategory> DocumentCategories { get; set; } = [];
}
