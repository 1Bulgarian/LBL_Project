using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LBL.Controllers
{
    public class InfoController : Controller
    {
        public IActionResult Contacts()
        {
            return View();
        }

        public IActionResult WhatisLoL()
        {
            return View();
        }

        public IActionResult LoLCompetitive()
        {
            return View();
        }

        public IActionResult BulgariansInLoL()
        {
            return View();
        }
    }
}
