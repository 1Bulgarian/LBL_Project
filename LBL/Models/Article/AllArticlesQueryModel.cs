namespace LBL.Models.Article
{
    using LBL.Services.Articles;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class AllArticlesQueryModel
    {
        public const int ArticlesPerPage = 5;

        public string Category { get; set; }

        public string OneCategory { get; set; }

        public IEnumerable<ArticleCategoriesViewModel> ManyCategories { get; set; }

        [Display(Name = "Search by text")]
        public string SearchTerm { get; init; }

        public ArticleSorting Sorting { get; init; }

        public int CurrentPage { get; set; } = 1;

        public int TotalArticles { get; set; }

        public IEnumerable<ArticleServiceModel> Articles { get; set; }

        public IEnumerable<string> Categories { get; set; }

    }
}
