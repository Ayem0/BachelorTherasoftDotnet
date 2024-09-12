namespace BachelorTherasoftDotnetDomain.Entities;

public class Slot : DefaultFields
{
    public string Id = Guid.NewGuid().ToString();
    public TimeOnly StartTime { get; set; }
    public TimeOnly EndTime { get; set; }

    public virtual List<MeetingCategory> Prestations { get; set; } = [];


    public Slot(TimeOnly startTime, TimeOnly endTime, List<MeetingCategory> prestations) {
        StartTime = startTime;
        EndTime = endTime;
        Prestations = prestations;
    }       
}
