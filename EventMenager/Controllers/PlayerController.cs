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
    public class PlayerController : Controller
    {
        private readonly IPlayerRepository _playerRepository;
        public PlayerController(IPlayerRepository playerRepository)
        {
            _playerRepository = playerRepository;
        }

        // GET: Player
        public ActionResult Index()
        {
            return View(_playerRepository.GetAll());
        }


        // GET: Player/Create
        public ActionResult Create()
        {
            return View(new PlayerModel());
        }

        // POST: Player/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PlayerModel playerModel)
        {
            _playerRepository.Add(playerModel);
                return RedirectToAction(nameof(Index));
          
        }

        // GET: Player/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_playerRepository.get(id));
        }

        // POST: Player/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, PlayerModel playerModel)
        {
            _playerRepository.Update(id,playerModel);
                return RedirectToAction(nameof(Index));
           
        }

       
        public ActionResult Delete(int id)
        {
            _playerRepository.Delete(id);

                return RedirectToAction(nameof(Index));
           
        }
    }
}