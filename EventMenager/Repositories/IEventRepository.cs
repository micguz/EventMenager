using EventMenager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventMenager.Repositories
{
    public interface IEventRepository
    {
        EventModel get(int eventId);
        IQueryable<EventModel> GetAll();
    }
}
