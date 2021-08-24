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
    using LBL.Infrastructure;
    using AutoMapper;
    using Microsoft.AspNetCore.Authorization;

    public class TeamsController : Controller
    {
        private readonly LBLDbContext data;
        private readonly ITeamService teams;
        private readonly IMapper mapper;

        public TeamsController(LBLDbContext data, ITeamService teams, IMapper mapper)
        {
            this.data = data;
            this.teams = teams;
            this.mapper = mapper;
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
                team.LogoURL,
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

            team.StaffMembers = this.teams.AllStaffMembers(id);

            return View(team);
        }

        public IActionResult Edit(int id)
        {
            var userId = this.User.GetId();

            //if(!User.IsAdmin())
            //{
            //    return RedirectToAction("Teams", "All");
            //}

            var team = this.teams.Details(id);

            var teamForm = this.mapper.Map<TeamFormModel>(team);

            teamForm.CategoriesRegions = this.teams.AllRegions();

            return View(teamForm);
        }

        [HttpPost]
        public IActionResult Edit(int id, TeamFormModel team)
        {

            if(!this.teams.RegionExists(team.RegionId))
            {
                this.ModelState.AddModelError(nameof(team.RegionId), "Region doesn't exist!");
            }

            if(ModelState.ErrorCount > 1)
            {
                team.CategoriesRegions = this.teams.AllRegions();

                return View(team);
            }

            var edited = this.teams.Edit(
                id,
                team.TeamFullName,
                team.TeamTagName,
                team.Description,
                team.LogoURL,
                team.Tier,
                team.RegionId);

            if(!edited)
            {
                return BadRequest();
            }

            TempData[GlobalMessageKey] = $"The team was edited.";

            return RedirectToAction(nameof(Details), new { id, information = team.GetInformation() });
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
