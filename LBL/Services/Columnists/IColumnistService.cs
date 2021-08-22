namespace LBL.Services.Columnists
{
    public interface IColumnistService
    {
        public bool IsColumnist(string userId);

        public int IdByUser(string userId);
    }
}
