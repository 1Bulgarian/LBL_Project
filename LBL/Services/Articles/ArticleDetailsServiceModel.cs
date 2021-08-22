namespace LBL.Services.Articles
{
    public class ArticleDetailsServiceModel : ArticleServiceModel
    {
        public string FirstName { get; init; }
        
        public string LastName { get; init; }

        public int AuthorId { get; init; }

        public string UserId { get; init; }
    }
}
