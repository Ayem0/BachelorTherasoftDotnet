﻿using BachelorTherasoftDotnetDomain.Classes;

namespace BachelorTherasoftDotnetDomain.Entities;

internal class Conversation : DefaultFields
{
    public string Id = Guid.NewGuid().ToString();
    public string ?Name { get; set; }
    public required List<string> MembersId { get; set; }
}

