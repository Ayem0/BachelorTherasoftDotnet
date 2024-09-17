﻿using BachelorTherasoftDotnetDomain.Classes;

namespace BachelorTherasoftDotnetDomain.Entities;

public class Participant : DefaultFields
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public required string WorkspaceId { get; set; }
    public required Workspace Workspace { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public string ?Email { get; set; }
    public string ?Address { get; set; }
    public string ?Country { get; set; }
    public string ?Description { get; set; }
    public DateTime ?DateOfBirth { get; set; }
    public List<Event> Events { get; set; } = [];

    public List<ParticipantCategory> ParticipantCategories { get; set; } = [];
}

