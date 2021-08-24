namespace LBL.Services.Teams
{
    using System.Collections.Generic;
    using System.Linq;
    using AutoMapper;
    using AutoMapper.QueryableExtensions;
    using LBL.Data;
    using LBL.Data.Models;
    using LBL.Models;
    using LBL.Services.Teams.Models;

    public class TeamService : ITeamService
    {
        private readonly LBLDbContext data;
        private readonly IConfigurationProvider mapper;

        public TeamService(LBLDbContext data, IMapper mapper)
        {
            this.data = data;
            this.mapper = mapper.ConfigurationProvider;
        }

        public TeamQueryServiceModel All(
            string region = null,
            string searchTerm = null,
            int currentPage = 1,
            int teamsPerPage = int.MaxValue
        )
        {
            var teamsQuery = this.data.Teams.AsQueryable();

            if(!string.IsNullOrWhiteSpace(region))
            {
                teamsQuery = teamsQuery.Where(c => c.Region.ShortName == region);
            }

            if(!string.IsNullOrWhiteSpace(searchTerm))
            {
                teamsQuery = teamsQuery.Where(c =>
                    (c.TeamFullName + " " + c.TeamTagName).ToLower().Contains(searchTerm.ToLower()) ||
                    c.Description.ToLower().Contains(searchTerm.ToLower()));
            }

            var totalTeams = teamsQuery.Count();

            var teams = GetTeams(teamsQuery
                .Skip((currentPage - 1) * teamsPerPage)
                .Take(teamsPerPage));

            return new TeamQueryServiceModel
            {
                TotalTeams = totalTeams,
                CurrentPage = currentPage,
                TeamsPerPage = teamsPerPage,
                Teams = teams
            };
        }

        public TeamDetailsServiceModel Details(int id)
            => this.data
            .Teams
            .Where(c => c.Id == id)
            .ProjectTo<TeamDetailsServiceModel>(this.mapper)
            .FirstOrDefault();

        public int Create(string longName, string shortName, string description, string logoUrl, string tier, int regionId)
        {
            var teamData = new Team
            {
                TeamFullName = longName,
                TeamTagName = shortName,
                Description = description,
                LogoURL = logoUrl,
                RegionId = regionId,
                Tier = tier
            };

            this.data.Teams.Add(teamData);
            this.data.SaveChanges();

            return teamData.Id;
        }

        public bool Edit (
            int id,
            string longName,
            string shortName,
            string description,
            string logo,
            string tier,
            int regionId)
        {
            var teamData = this.data.Teams.Find(id);

            if(teamData ==null)
            {
                return false;
            }

            teamData.TeamFullName = longName;
            teamData.TeamTagName = shortName;
            teamData.Description = description;
            teamData.LogoURL = logo;
            teamData.Tier = tier;
            teamData.RegionId = regionId;

            this.data.SaveChanges();

            return true;
        }

        public IEnumerable<string> GetAllRegions()
            => this.data
                .Regions
                .Select(c=> c.ShortName)
                .ToList();

        public IEnumerable<TeamRegionServiceModel> AllRegions()
            => this.data
            .Regions
            .ProjectTo<TeamRegionServiceModel>(this.mapper)
            .ToList();

        public bool RegionExists(int regionId)
            => this.data
            .Regions
            .Any(c => c.Id == regionId);

        public IEnumerable<TeamStaffMemberServiceModel> AllStaffMembers(int teamId)
            => this.data
            .StaffMembers
            .Where(c=>c.TeamId == teamId)
            .ProjectTo<TeamStaffMemberServiceModel>(this.mapper)
            .ToList();

        private IEnumerable<TeamServiceModel> GetTeams(IQueryable<Team> teamQuery)
            => teamQuery
                .ProjectTo<TeamServiceModel>(this.mapper)
                .ToList();
    }
}
