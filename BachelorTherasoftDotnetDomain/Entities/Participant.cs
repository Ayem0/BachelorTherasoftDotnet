using BachelorTherasoftDotnetDomain.Classes;

namespace BachelorTherasoftDotnetDomain.Entities;

internal class Participant : DefaultFields
{
    public string Id = Guid.NewGuid().ToString();
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public string ?Email { get; set; }
    public string ?Address { get; set; }
    public string ?Description { get; set; }
    public List<string> ?ParticipantCategoriesId { get; set; }
    public DateTime ?DateOfBirth { get; set; }
}

