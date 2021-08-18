namespace LBL.Controllers.Api
{
    using LBL.Data;
    using LBL.Services.Articles;
    using Microsoft.AspNetCore.Mvc;
    using System.Collections;
    using System.Linq;

    [ApiController]
    [Route("api/teams")]
    public class TeamsApiController : ControllerBase
    {
        private readonly IArticleService articles;

        public TeamsApiController(IArticleService articles)
            => this.articles = articles;

        //public ArticlesApiController(IArticleService articles)
        //    => this.articles = articles;

        //[HttpGet]
        //public ArticleQueryServiceModel All([FromQuery] AllArticlesApiRequestModel query)
        //    =>this.articles.All(
        //        query.
        //        )
    }
}
