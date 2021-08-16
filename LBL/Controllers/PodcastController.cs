namespace LBL.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public class PodcastController : Controller
    {
        public IActionResult LBL()
        {
            return View();
        }
    }
}
