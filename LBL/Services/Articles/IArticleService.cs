namespace LBL.Services.Articles
{
    using LBL.Models;
    using System.Collections.Generic;

    public interface IArticleService
    {
        ArticleQueryServiceModel All(
            string category,
            string searchTerm,
            ArticleSorting sorting,
            int currentPage,
            int articlesPerPage);

        IEnumerable<string> AllArticleCategories();
    }
}
