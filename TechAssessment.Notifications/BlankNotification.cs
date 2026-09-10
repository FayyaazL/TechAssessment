using TechAssessment.Core.Entities;
using TechAssessment.Notifications.Interfaces;

namespace TechAssessment.Notifications
{
    public class BlankNotification : INotification
    {
        public void SendAttendingNotification(Attendee attendee, CalendarEvent calendarEvent)
        {
            // This is a blank notification implementation, it does not send any notifications.
        }

        public void SendNotAttendingNotification(Attendee attendee, CalendarEvent calendarEvent)
        {
            // This is a blank notification implementation, it does not send any notifications.
        }
    }
}
