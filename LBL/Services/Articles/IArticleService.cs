namespace LBL.Services.Articles
{
    using LBL.Models;
    using LBL.Services;
    using System.Collections.Generic;

    public interface IArticleService
    {
        ArticleQueryServiceModel All(
            string category =null,
            string searchTerm=null,
            ArticleSorting sorting=ArticleSorting.DatePublishedDesc,
            int currentPage=1,
            int articlesPerPage=int.MaxValue);

        IEnumerable<string> AllArticleCategories();

        ArticleDetailsServiceModel Details(int id);

        ArticleDetailsServiceModel AuthorName(int authorId);

        int Create(
            string title,
            string text,
            string description,
            string imageUrl,
            int categoryId,
            int authorId);

        bool Edit(
            int articleId,
            string title,
            string text,
            string description,
            string imageUrl,
            int categoryId);

        IEnumerable<ArticleServiceModel> ByAuthor(string userId);

        IEnumerable<ArticleCategoriesServiceModel> AllCategories();

        IEnumerable<ArticleAuthorServiceModel> AuthorNames(int authorId);

        bool CategoryExists(int categoryId);

        bool IsByColumnist(int articleId, int authorId);
    }
}
