namespace LBL.Services.Statistics
{
    using System.Linq;
    using LBL.Data;

    public class StatisticsService : IStatisticsService
    {
        private readonly LBLDbContext data;

        public StatisticsService(LBLDbContext data)
            =>this.data = data;

        public StatisticsServiceModel Total()
        {
            var totalTeams = this.data.Teams.Count();
            var totalUsers = this.data.Users.Count();
            var totalArticles = this.data.Articles.Count();

            return new StatisticsServiceModel
            {
                TotalArticles = totalArticles,
                TotalTeams = totalTeams,
                TotalUsers = totalUsers
            };
        }
    }
}
