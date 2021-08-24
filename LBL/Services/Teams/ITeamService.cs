namespace LBL.Services.Teams
{
    using System.Collections.Generic;
    using LBL.Models;
    using LBL.Services.Teams.Models;

    public interface ITeamService
    {
        public TeamQueryServiceModel All(
            string region = null,
            string searchTerm = null,
            int currentPage = 1,
            int teamsPerPage = int.MaxValue
        );

        int Create(
            string teamLongName,
            string teamShortName,
            string description,
            string logoUrl,
            string tier,
            int regionId);

        bool Edit(
            int teamId,
            string teamLongName,
            string teamShortName,
            string description,
            string logoUrl,
            string tier,
            int regionId);

        TeamDetailsServiceModel Details(int teamId);

        bool RegionExists(int regionId);

        public IEnumerable<string> GetAllRegions();

        public IEnumerable<TeamRegionServiceModel> AllRegions();

        public IEnumerable<TeamStaffMemberServiceModel> AllStaffMembers(int teamId);

        //public IEnumerable<string> GetStaffMembersIGN();
    }
}
