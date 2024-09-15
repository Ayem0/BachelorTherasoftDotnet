﻿using BachelorTherasoftDotnetDomain.Classes;

namespace BachelorTherasoftDotnetDomain.Entities;

internal class Room : DefaultFields
{
    public string Id = Guid.NewGuid().ToString();
    public required string ZoneId { get; set; }
    public required string Name { get; set; }
}
