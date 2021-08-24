namespace LBL.Controllers
{
    using System.Collections.Generic;
    using System.Linq;
    using LBL.Data;
    using LBL.Data.Models;
    using LBL.Infrastructure;
    using LBL.Models.Players;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    public class PlayersController : Controller
    {
        private readonly LBLDbContext data;

        public PlayersController(LBLDbContext data)
            => this.data = data;

        [Authorize]
        public IActionResult Add()
        {
            if (!this.User.IsAdmin())
            {
                return RedirectToAction("All", "Teams");
            }
            return View(new AddPlayerFormModel
            {
                StaffsTeams = this.GetPlayersTeam()
            });
        }

        [HttpPost]
        [Authorize]
        public IActionResult Add(AddPlayerFormModel player)
        {
            if (this.data.Teams.Any(c => c.Id == player.TeamId))
            {
                this.ModelState.AddModelError(nameof(player.TeamId), "This team doesn't exist");
            }

            if (ModelState.ErrorCount > 1)
            {
                player.StaffsTeams = this.GetPlayersTeam();

                return View(player);
            }

            var staffData = new StaffMember
            {
                IGN = player.IGN,
                FirstName = player.FirstName,
                LastName = player.LastName,
                Position = player.Position,
                ImageURL = player.ImageURL,
                CountryOfBirth = player.CountryOfBirth,
                TeamId = player.TeamId,
            };

            this.data.StaffMembers.Add(staffData);
            this.data.SaveChanges();

            return RedirectToAction("Index", "Home");
        }

        private IEnumerable<StaffMembersTeamsViewModel> GetPlayersTeam()
            => this.data
            .Teams
            .Select(c => new StaffMembersTeamsViewModel
            {
                Id = c.Id,
                Name = c.TeamFullName,
                Tag = c.TeamTagName,
                Tier = c.Tier
            })
            .ToList();
    }
}
