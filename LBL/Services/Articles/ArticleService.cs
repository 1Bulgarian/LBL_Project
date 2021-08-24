namespace LBL.Services.Articles
{
    using System.Collections.Generic;
    using System.Linq;
    using AutoMapper;
    using AutoMapper.QueryableExtensions;
    using LBL.Data;
    using LBL.Data.Models;
    using LBL.Models;

    public class ArticleService : IArticleService
    {
        private readonly LBLDbContext data;
        private readonly IConfigurationProvider mapper;

        public ArticleService(LBLDbContext data, IMapper mapper)
        {
            this.data = data;
            this.mapper = mapper.ConfigurationProvider;
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

            var articles = GetArticles(articlesQuery
                .Skip((currentPage - 1) * articlesPerPage)
                .Take(articlesPerPage));

            return new ArticleQueryServiceModel
            {
                TotalArticles = totalArticles,
                CurrentPage = currentPage,
                ArticlesPerPage = articlesPerPage,
                Articles = articles
            };
        }

        public ArticleDetailsServiceModel Details(int id)
            => this.data
            .Articles
            .Where(c => c.Id == id)
            .ProjectTo<ArticleDetailsServiceModel>(this.mapper)
            .FirstOrDefault();

        public IEnumerable<ArticleCategoriesServiceModel> AllCategories()
            => this.data
            .Categories
            .ProjectTo<ArticleCategoriesServiceModel>(this.mapper)
            .ToList();

        public ArticleDetailsServiceModel AuthorName(int authorId)
            => this.data
            .Columnists
            .Where(c => c.Id == authorId)
            .ProjectTo<ArticleDetailsServiceModel>(this.mapper)
            .FirstOrDefault();

        public bool CategoryExists(int categoryId)
            => this.data
            .Categories
            .Any(c => c.Id == categoryId);

        public int Create(string title, string description, string text, string imageUrl, int categoryId, int authorId)
        {
            var articleData = new Article
            {
                Title = title,
                Description = description,
                Image = imageUrl,
                Text = text,
                CategoryId = categoryId,
                AuthorId = authorId
            };

            this.data.Articles.Add(articleData);
            this.data.SaveChanges();

            return articleData.Id;
        }

        public bool Edit(
            int id,
            string title,
            string description,
            string text,
            string imageUrl,
            int categoryId
            )
        {
            var articleData = this.data.Articles.Find(id);

            if (articleData == null) return false;

            articleData.Title = title;
            articleData.Description = description;
            articleData.Text = text;
            articleData.Image = imageUrl;
            articleData.CategoryId = categoryId;

            this.data.SaveChanges();

            return true;
        }

        public IEnumerable<string> AllArticleCategories()
            => this.data
                .Categories
                .Select(c => c.Name)
                .Distinct()
                .OrderBy(br => br)
                .ToList();


        public IEnumerable<ArticleServiceModel> ByAuthor(string userId)
            => GetArticles(this.data.Articles.Where(c => c.Author.UserId == userId));
        

        public bool IsByColumnist(int articleId, int authorId)
            => this.data
            .Articles
            .Any(c => c.Id == articleId && c.AuthorId == authorId);

        private IEnumerable<ArticleServiceModel> GetArticles(IQueryable<Article> articleQuery)
            => articleQuery
            .ProjectTo<ArticleServiceModel>(this.mapper)
            .ToList();

        public IEnumerable<ArticleAuthorServiceModel> AuthorNames(int authorId)
            => this.data
            .Columnists
            .Where(c => c.Id == authorId)
            .ProjectTo<ArticleAuthorServiceModel>(this.mapper)
            .ToList();

    }
}
