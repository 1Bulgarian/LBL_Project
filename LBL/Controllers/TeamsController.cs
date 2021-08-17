namespace LBL.Controllers
{
    using System.Collections.Generic;
    using System.Linq;
    using LBL.Data;
    using LBL.Data.Models;
    using LBL.Models.Teams;
    using Microsoft.AspNetCore.Mvc;

    public class TeamsController : Controller
    {
        private readonly LBLDbContext data;

        public TeamsController(LBLDbContext data) 
            => this.data = data;

        public IActionResult Add() => View(new AddTeamFormModel
        {
            CategoriesRegions = this.GetRegionCategories()
        });

        public IActionResult All()
        {
            var teams = this.data
                .Teams
                .OrderBy(c=>c.TeamTagName)
                .Select(c => new TeamListViewModel
                {
                    Id = c.Id,
                    Tag = c.TeamTagName,
                    FullName = c.TeamFullName,
                    LogoURL = c.LogoURL,
                    Region = c.Region.ShortName
                })
                .ToList();

            return View(teams);
        }
              
        [HttpPost]
        public IActionResult Add(AddTeamFormModel team)
        {
            if(this.data.Regions.Any(c=>c.Id==team.RegionId))
            {
                this.ModelState.AddModelError(nameof(team.RegionId), "This region doesn't exist");
            }

            if(ModelState.ErrorCount>1)
            {
                team.CategoriesRegions = this.GetRegionCategories();

                return View(team);
            }

            var teamData = new Team
            {
                TeamFullName = team.TeamFullName,
                TeamTagName = team.TeamTagName,
                Description = team.Description,
                LogoURL = team.Logo,
                RegionId = team.RegionId,
                Tier = team.Tier
            };

            this.data.Teams.Add(teamData);
            this.data.SaveChanges();

            return RedirectToAction(nameof(All));
        }

        private IEnumerable<TeamRegionViewModel> GetRegionCategories()
            => this.data
            .Regions
            .Select(c => new TeamRegionViewModel
            {
                Id = c.Id,
                Name = c.ShortName
            })
            .ToList();
    }
}
