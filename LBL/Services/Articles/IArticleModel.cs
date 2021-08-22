namespace LBL.Services.Articles
{
    public interface IArticleModel
    {
        string Title { get; }

        string Description { get; }

        string Image { get; }
    }
}
