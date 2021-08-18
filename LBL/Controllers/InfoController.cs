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
    }
}
