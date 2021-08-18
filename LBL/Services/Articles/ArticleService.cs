namespace LBL.Services.Articles
{
    using System.Collections.Generic;
    using System.Linq;
    using LBL.Data;
    using LBL.Models;

    public class ArticleService : IArticleService
    {
        private readonly LBLDbContext data;

        public ArticleService(LBLDbContext data)
        {
            this.data = data;
        }

        public ArticleQueryServiceModel All(
            string category,
            string searchTerm,
            ArticleSorting sorting,
            int currentPage,
            int articlesPerPage)
        {

            var articlesQuery = this.data.Articles.AsQueryable();

            if (!string.IsNullOrWhiteSpace(category))
            {
                articlesQuery = articlesQuery
                    .Where(c => c.Category.Name == category);
            }

            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                articlesQuery = articlesQuery.Where(c =>
                    c.Title.ToLower().Contains(searchTerm.ToLower()) ||
                    c.Description.ToLower().Contains(searchTerm.ToLower()) ||
                    c.Category.Name.ToLower().Contains(searchTerm.ToLower()));
            }

            articlesQuery = sorting switch
            {
                ArticleSorting.AtoZ => articlesQuery.OrderBy(c => c.Title),
                ArticleSorting.ZtoA => articlesQuery.OrderByDescending(c => c.Title),
                ArticleSorting.DatePublishedDesc => articlesQuery.OrderBy(c => c.Id),
                ArticleSorting.DatePublished or _ => articlesQuery.OrderByDescending(c => c.Id)

            };

            var totalArticles = articlesQuery.Count();

            var articles = articlesQuery
                .Skip((currentPage - 1) * articlesPerPage)
                .Take(articlesPerPage)
                .Select(c => new ArticleServiceModel
                {
                    Id = c.Id,
                    Title = c.Title,
                    Description = c.Description,
                    Text = c.Text,
                    Image = c.Image,
                    Category = c.Category.Name,
                    Author = c.AuthorId
                })
                .ToList();

            var articleCategories = this.data
            .Categories
            .Select(c => new ArticleCategoriesServiceModel
            {
                CategoryId = c.Id,
                Name = c.Name
            })
            .ToList();

            return new ArticleQueryServiceModel
            {
                TotalArticles = totalArticles,
                CurrentPage = currentPage,
                ArticlesPerPage = articlesPerPage,
                Articles = articles
            };
        }

        public IEnumerable<string> AllArticleCategories()
            => this.data
                .Categories
                .Select(c => c.Name)
                .Distinct()
                .OrderBy(br => br)
                .ToList();

    }
}
