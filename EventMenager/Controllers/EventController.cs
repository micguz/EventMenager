using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventMenager.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EventMenager.Controllers
{
    public class EventController : Controller
    {
        private readonly IEventRepository _eventRepository;

        public EventController(IEventRepository eventRepository)
        {
            _eventRepository = eventRepository;
        }

        // GET: Event
        public ActionResult Index()
        {
            return View(_eventRepository.GetAll());
        }

        // GET: Event/Details/5
        public ActionResult Details(int id)
        {
            return View(_eventRepository.get(id));
        }

    }
}