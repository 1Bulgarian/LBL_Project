namespace LBL.Controllers
{
    using System.Linq;
    using LBL.Data;
    using LBL.Data.Models;
    using LBL.Infrastructure;
    using LBL.Models;
    using LBL.Models.Columnists;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    using static WebConstants;

    public class ColumnistsController : Controller
    {
        private readonly LBLDbContext data;

        public ColumnistsController(LBLDbContext data) => this.data = data;

        [Authorize]
        public IActionResult Become() => View();

        [HttpPost]
        [Authorize]
        public IActionResult Become(BecomeColumnistFormModel columnist)
        {
            var userId = this.User.GetId();

            var userIdAlreadyColumnist = this.data
                .Columnists
                .Any(d => d.UserId == userId);

            if (userIdAlreadyColumnist) { return BadRequest(); }

            if (!ModelState.IsValid) { return View(columnist); }

            var columnistData = new Columnist
            {
                FirstName = columnist.FirstName,
                LastName = columnist.LastName,
                UserId = userId
            };

            this.data.Columnists.Add(columnistData);
            this.data.SaveChanges();

            TempData[GlobalMessageKey] = "Thank you for becoming a columnist. Welcome aboard!";

            return RedirectToAction(nameof(ArticlesController.All), "Articles");
        }

    }
}
