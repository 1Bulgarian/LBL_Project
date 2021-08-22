namespace LBL.Services.Articles
{
    public class ArticleServiceModel : IArticleModel
    {
        public int Id { get; init; }

        public string Title { get; init; }

        public string Description { get; init; }

        public string Text { get; init; }

        public string Image { get; init; }

        public string CategoryName { get; init; }
    }
}
