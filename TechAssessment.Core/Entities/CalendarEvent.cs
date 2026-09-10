namespace TechAssessment.Core.Entities
{
    public class CalendarEvent
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public List<Attendee> Attendees { get; set; } = new List<Attendee>();
    }
}
