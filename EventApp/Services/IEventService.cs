using EventApp.Entities;
using EventApp.Data;

namespace EventApp.Services
{
    public interface IEventService
    {
        List<Event> GetEvents();
        Event GetEvent(int id);
        Task AddEvent(Event _event);
        void RemoveEvent(Event _event);
        void UpdateEvent(Event _event);

        List<Status> GetStatus();
        List<AdminStatus> GetAdminStatus();
        List<Purpose> GetPurpose();
        List<EventApp.Entities.Type> GetType();

    }
}
