namespace TechAssessment.Core.Entities
{
    public class Attendee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public List<CalendarEvent> Events { get; set; } = new List<CalendarEvent>();
    }
}
