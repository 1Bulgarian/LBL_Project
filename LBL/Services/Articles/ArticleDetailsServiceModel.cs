namespace LBL.Services.Articles
{
    using System.Collections.Generic;

    public class ArticleDetailsServiceModel : ArticleServiceModel
    {
        public string FirstName { get; init; }
        
        public string LastName { get; init; }

        public int AuthorId { get; init; }

        public string UserId { get; init; }

        public IEnumerable<ArticleAuthorServiceModel> AuthorNames;
    }
}
