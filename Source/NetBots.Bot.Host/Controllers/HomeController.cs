﻿using NetBots.WebModels;
using Newtonsoft.Json;
using GrahamBot;
using System.Web.Mvc;

namespace NetBots.Bot.Host.Controllers
{
    public class HomeController : Controller
    {
        [HttpPost]
        public ActionResult Index(MoveRequest moveRequest)
        {
            var moves = new GrahamAi().GetMoves(moveRequest);

            return Json(moves);
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}
