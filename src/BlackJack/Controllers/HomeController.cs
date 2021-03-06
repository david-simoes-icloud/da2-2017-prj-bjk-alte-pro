﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using Newtonsoft.Json;
using BlackJack.Models;

namespace BlackJack.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        
        public IActionResult Error()
        {
            return View();
        }

        public IActionResult Regras()
        {
            return View();
        }

        public IActionResult HighScores()
        {
            List<Game> games = Repository.Games;
            games.Sort();
            games.Reverse();
            return View(games);
        }

       

    }
}
