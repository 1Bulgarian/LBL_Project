namespace LBL.Services.Articles
{
    using LBL.Models;
    using System.Collections.Generic;

    public class ArticleQueryServiceModel
    {
        public int CategoryID { get; init; }

        public string OneCategory { get; init; }

        public IEnumerable<ArticleCategoriesServiceModel> ManyCategories { get; init; }

        public string SearchTerm { get; init; }

        public ArticleSorting Sorting { get; init; }

        public int CurrentPage { get; init; }

        public int ArticlesPerPage { get; init; }

        public int TotalArticles { get; init; }

        public IEnumerable<ArticleServiceModel> Articles { get; init; }
    }
}
