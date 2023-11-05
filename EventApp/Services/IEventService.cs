using EventApp.Entities;
using EventApp.Data;

namespace EventApp.Services
{
    public interface IEventService
    {
        List<Event> GetEvents();
        Event GetEvent(int id);
        Task AddEvent(Event _event);
        Task RemoveEvent(Event _event);
        Task UpdateEvent(Event _event);
        List<Status> GetStatus();
        List<AdminStatus> GetAdminStatus();
        List<Purpose> GetPurpose();
        List<EventApp.Entities.Type> GetType();

    }
}
