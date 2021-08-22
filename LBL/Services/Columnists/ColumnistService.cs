namespace LBL.Services.Columnists
{
    using System.Linq;
    using LBL.Data;

    public class ColumnistService : IColumnistService
    {
        private readonly LBLDbContext data;

        public ColumnistService(LBLDbContext data)
            => this.data = data;

        public bool IsColumnist(string userId)
            => this.data
            .Columnists
            .Any(d => d.UserId == userId);

        public int IdByUser(string userId)
            => this.data
            .Columnists
            .Where(d => d.UserId == userId)
            .Select(d => d.Id)
            .FirstOrDefault();
    }
}
