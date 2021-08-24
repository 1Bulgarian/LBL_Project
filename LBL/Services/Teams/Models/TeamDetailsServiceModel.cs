using System.Collections.Generic;

namespace LBL.Services.Teams.Models
{
    public class TeamDetailsServiceModel : TeamServiceModel
    {
        public string Description { get; init; }

        public int CategoryId { get; init; }

        public IEnumerable<TeamStaffMemberServiceModel> StaffMembers;
    }
}
