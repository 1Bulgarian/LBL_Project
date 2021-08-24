namespace LBL.Controllers
{
    using System.Collections.Generic;
    using System.Linq;
    using LBL.Infrastructure.Extensions;
    using LBL.Data;
    using LBL.Data.Models;
    using LBL.Models.Teams;
    using LBL.Services.Teams;
    using LBL.Services.Teams.Models;
    using Microsoft.AspNetCore.Mvc;

    using static WebConstants;

    public class TeamsController : Controller
    {
        private readonly LBLDbContext data;
        private readonly ITeamService teams;

        public TeamsController(LBLDbContext data, ITeamService teams)
        {
            this.data = data;
            this.teams = teams;
        }

        public IActionResult All([FromQuery] AllTeamsQueryModel query)
        {
            var queryResult = this.teams.All(
                query.Region,
                query.SearchTerm,
                query.CurrentPage,
                AllTeamsQueryModel.TeamsPerPage);

            var teamRegions = this.teams.GetAllRegions();

            query.Regions = teamRegions;
            query.TotalTeams = queryResult.TotalTeams;
            query.Teams = queryResult.Teams;

            return View(query);
        }
              
        public IActionResult Add()
        {
            return View(new TeamFormModel
            {
                CategoriesRegions = this.teams.AllRegions()
            });
        }

        [HttpPost]
        public IActionResult Add(TeamFormModel team)
        {
            if(!this.teams.RegionExists(team.RegionId))
            {
                this.ModelState.AddModelError(nameof(team.RegionId), "Region doesn't exist.");
            }

            if(ModelState.ErrorCount > 1)
            {
                team.CategoriesRegions = this.teams.AllRegions();

                return View(team);
            }

            var teamId = this.teams.Create(
                team.TeamFullName,
                team.TeamTagName,
                team.Description,
                team.Logo,
                team.Tier,
                team.RegionId);

            TempData[GlobalMessageKey] = "This team has been added to the database.";

            return RedirectToAction(nameof(Details), new { id = teamId, information = team.GetInformation() });

        }

        public IActionResult Details(int id, string information)
        {
            var team = this.teams.Details(id);

            if(information != team.GetInformation())
            {
                return BadRequest();
            }

            return View(team);
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
