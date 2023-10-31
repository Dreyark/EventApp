using EventApp.Entities;
using EventApp.Data;

namespace EventApp.Services
{
    public interface IEventService
    {
        List<Event> GetEvents();
        Event GetEvent(int id);
        void AddEvent(Event _event);
        void RemoveEvent(Event _event);
        void UpdateEvent(Event _event);
    }
}
