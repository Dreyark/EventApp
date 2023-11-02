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
        public Task AddEvent(Event _event)
        {
            _context.Event.Add(_event);
            _context.SaveChangesAsync();
            return Task.CompletedTask;
        }

        public Task RemoveEvent(Event _event)
        {
            if (_event != null)
            {
                _context.Event.Remove(_event);
                _context.SaveChangesAsync();
            }
            return Task.CompletedTask;
        }

        public Task UpdateEvent(Event _event)
        {
            if (_event != null)
            {
                _context.Event.Update(_event);
                _context.SaveChangesAsync();
            }
            return Task.CompletedTask;
        }

        public List<Status> GetStatus()
        {
            return _context.Status.ToList();
        }

        public List<AdminStatus> GetAdminStatus()
        {
            return _context.AdminStatus.ToList();
        }

        public List<Purpose> GetPurpose()
        {
            return _context.Purpose.ToList();
        }

        List<Entities.Type> IEventService.GetType()
        {
            return _context.Type.ToList();
        }
    }
}
