using System;
using BachelorTherasoftDotnetDomain.Classes;

namespace BachelorTherasoftDotnetDomain.Entities;

public class Document : DefaultFields
{
    public string Id = Guid.NewGuid().ToString();
    public required string TaskId { get; set; }
}
