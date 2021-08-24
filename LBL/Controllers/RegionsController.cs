namespace LBL.Controllers
{
    using LBL.Data;
    using LBL.Data.Models;
    using LBL.Infrastructure;
    using LBL.Models.Regions;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using System.Linq;

    public class RegionsController : Controller
    {
        private readonly LBLDbContext data;

        public RegionsController(LBLDbContext data)
            => this.data = data;

        [Authorize]
        public IActionResult Add()
        {
            if (!this.User.IsAdmin())
            {
                return RedirectToAction("All", "Teams");
            }
            return View(new AddRegionFormModel());
        }

        [HttpPost]
        [Authorize]
        public IActionResult Add(AddRegionFormModel region)
        {

            if (ModelState.ErrorCount >0)
            {
                return View(region);
            }

            var regionData = new Region
            {
                FullName = region.FullName,
                ShortName = region.ShortName,
                Location = region.Location,
                LogoUrl = region.LogoURL,
                Organizer = region.Organizer,
                Tier = 1
            };

            this.data.Regions.Add(regionData);
            this.data.SaveChanges();

            return RedirectToAction("Index", "Home");
        }
    }
}
