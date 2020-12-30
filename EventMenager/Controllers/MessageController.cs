using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventMenager.Models;
using EventMenager.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EventMenager.Controllers
{
    public class MessageController : Controller
    {
        private readonly IMessageRepository _messageRepository;
        public MessageController(IMessageRepository messageRepository)
        {
            _messageRepository = messageRepository;
        }
        // GET: Message
        public ActionResult Index()
        {
            return View(new MessageModel());
        }


        // POST: Message/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(MessageModel messageModel)
        {
            _messageRepository.AddMessage(messageModel);
            return RedirectToAction(nameof(Index));
        
        }

    }
}