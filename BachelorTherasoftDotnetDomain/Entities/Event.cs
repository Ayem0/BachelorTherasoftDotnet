using BachelorTherasoftDotnetDomain.Classes;

namespace BachelorTherasoftDotnetDomain.Entities;

public class Event : DefaultFields
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public TimeOnly StartTime { get; set; }
    public TimeOnly EndTime { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string ?Description { get; set; }

    public List<Participant> Participants { get; set; } = [];
    public List<User> Users { get; set; } = [];
    public List<EventCategory> EventCategories { get; set; } = [];
    public EventStatus ?EventStatus { get; set; }
}

