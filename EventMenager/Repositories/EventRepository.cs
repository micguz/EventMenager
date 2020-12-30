using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventMenager.Models;

namespace EventMenager.Repositories
{
    public class EventRepository : IEventRepository
    {
        private readonly EventMenagerContext _context;

        public EventRepository(EventMenagerContext context)
        {
            _context = context;
        }

        public EventModel get(int eventId)
        => _context.Events.FirstOrDefault(s => s.EventId == eventId);

        public IQueryable<EventModel> GetAll()
        => _context.Events.Where(s=>s.EventId!=0);
    }
}
