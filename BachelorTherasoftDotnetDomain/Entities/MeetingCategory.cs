namespace BachelorTherasoftDotnetDomain.Entities
{
    public class MeetingCategory : DefaultFields
    {
        public string Id = Guid.NewGuid().ToString();
        public required string Name { get; set; }

        public MeetingCategory(string name) {
            Name = name;
        }
    }
}
