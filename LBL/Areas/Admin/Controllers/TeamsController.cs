namespace LBL.Areas.Admin.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class TeamsController : AdminController
    {
        public IActionResult Index() => View();
    }
}
