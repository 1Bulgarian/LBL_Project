namespace LBL.Data.Models.Api.Articles
{
    using LBL.Models;
    using LBL.Models.Article;

    public class AllArticlesApiRequestModel
    {
        public int CategoryId { get; init; }

        public string SearchTerm { get; init; }

        public ArticleSorting Sorting { get; init; }

        public int CurrentPage { get; init; } = 1;

        public int ArticlesPerPage { get; init; } = 5;
    }
}
