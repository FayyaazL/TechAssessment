namespace TechAssessment.Services.Interfaces
{
    public interface ICalendarService
    {
        Task AddAttendeeToEventAsync(int calendarEventId, int attendeeId);
        Task RemoveAttendeeFromEventAsync(int calendarEventId, int attendeeId);
    }
}
