namespace LBL.Models.Teams
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using LBL.Services.Teams.Models;

    public class AllTeamsQueryModel
    {
        public const int TeamsPerPage = 18;

        public string Region { get; set; }

        public IEnumerable<TeamRegionServiceModel> ManyRegions { get; set; }

        [Display(Name = "Search by text")]
        public string SearchTerm { get; init; }

        public int CurrentPage { get; init; } = 1;

        public int TotalTeams { get; set; }

        public IEnumerable<string> Regions { get; set; }

        public IEnumerable<TeamServiceModel> Teams { get; set; }
    }
}
