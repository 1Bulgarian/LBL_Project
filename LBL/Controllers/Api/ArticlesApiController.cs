namespace LBL.Controllers.Api
{
    using Microsoft.AspNetCore.Mvc;
    using LBL.Services.Articles;


    [ApiController]
    [Route("api/cars")]
    public class ArticlesApiController : ControllerBase
    {
        private readonly IArticleService articles;

        public ArticlesApiController(IArticleService articles)
            => this.articles = articles;

        [HttpGet]
        public ArticleQueryServiceModel All([FromQuery] AllArticlesApiRequestModel query)
            => this.articles.All(
                query.Category,
                query.SearchTerm,
                query.Sorting,
                query.CurrentPage,
                query.CarsPerPage);
    }
}
