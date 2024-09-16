using BachelorTherasoftDotnetDomain.Classes;

namespace BachelorTherasoftDotnetDomain.Entities;

public class Slot : DefaultFields
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public required string RoomId { get; set; }
    public required Room Room { get; set; }
    public TimeOnly StartTime { get; set; }
    public TimeOnly EndTime { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public required List<DayOfWeek> RepetitionDays { get; set; } 
    public required List<EventCategory> EventCategories { get; set; }
    public int RepetitionNumber { get; set; }
    public required string RepetitionType { get; set; } // string a changer par un enum dayly weekly monthly annual

}
