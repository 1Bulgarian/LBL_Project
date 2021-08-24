using LBL.Services.Teams.Models;

namespace LBL.Infrastructure.Extensions
{
    public static class ModelExtensions
    {
        public static string GetInformation(this ITeamModel team)
            => team.TeamTagName + "-" + team.TeamFullName;
    }
}
