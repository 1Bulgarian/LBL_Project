namespace LBL.Controllers.Api
{
    using LBL.Models;

    public class AllArticlesApiRequestModel
    {
        public string Category { get; init; }

        public string SearchTerm { get; init; }

        public ArticleSorting Sorting { get; init; }

        public int CurrentPage { get; init; } = 1;

        public int CarsPerPage { get; init; } = 10;
    }
}
