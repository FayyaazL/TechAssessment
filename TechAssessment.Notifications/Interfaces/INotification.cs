using TechAssessment.Core.Entities;

namespace TechAssessment.Notifications.Interfaces
{
    public interface INotification
    {
        void SendAttendingNotification(Attendee attendee, CalendarEvent calendarEvent);
        void SendNotAttendingNotification(Attendee attendee, CalendarEvent calendarEvent);
    }
}
