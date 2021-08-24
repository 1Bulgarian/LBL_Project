namespace LBL.Services.Teams.Models
{
    using System.Collections.Generic;

    public class TeamQueryServiceModel
    {
        public int CurrentPage { get; init; }

        public int TeamsPerPage { get; init; }

        public int TotalTeams { get; init; }

        public IEnumerable<TeamServiceModel> Teams { get; init; }

        public IEnumerable<TeamStaffMemberServiceModel> StaffMembers { get; init; }
    }
}
