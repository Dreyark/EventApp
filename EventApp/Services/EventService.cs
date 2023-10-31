using EventApp.Data;
using EventApp.Entities;

namespace EventApp.Services
{
    public class EventService : IEventService
    {
        private readonly ApplicationDbContext _context;

        public EventService(ApplicationDbContext context)
        { _context = context; }

        public List<Event> GetEvents()
        {
            return _context.Event.ToList();
        }
        public Event GetEvent(int id)
        {
            var _event = _context.Event.FirstOrDefault(e => e.Id == id);
            if (_event == null)
            {
                throw new ArgumentNullException("id");
            }
            return _event;
        }
        public void AddEvent(Event _event)
        {
            _context.Event.Add(_event);
            _context.SaveChangesAsync();
        }

        public void RemoveEvent(Event _event)
        {
            if (_event != null)
            {
                _context.Event.Remove(_event);
                _context.SaveChangesAsync();
            }
        }

        public void UpdateEvent(Event _event)
        {
            if (_event != null)
            {
                _context.Event.Update(_event);
                _context.SaveChangesAsync();
            }
        }
    }
}
