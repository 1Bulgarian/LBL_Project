namespace LBL.Services.Teams.Models
{
    public class TeamServiceModel : ITeamModel
    {
        public int Id { get; init; }

        public string TeamFullName { get; init; }

        public string TeamTagName { get; init; }

        public string LogoURL { get; init; }

        public string RegionName { get; set; }
    }
}
