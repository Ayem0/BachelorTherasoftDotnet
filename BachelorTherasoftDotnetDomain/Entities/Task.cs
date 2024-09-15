using BachelorTherasoftDotnetDomain.Classes;

namespace BachelorTherasoftDotnetDomain.Entities;

internal class Task : DefaultFields
{
    public string Id = Guid.NewGuid().ToString();
    public TimeOnly StartTime { get; set; }
    public TimeOnly EndTime { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string ?Description { get; set; }
    public List<string> ?ParticipantsId { get; set; }
    public List<string> ?MembersId { get; set; }
    public List<string> ?CategoriesId { get; set; }
}

