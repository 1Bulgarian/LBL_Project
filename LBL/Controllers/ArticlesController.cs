namespace LBL.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.AspNetCore.Mvc;
    using LBL.Data;
    using LBL.Models.Article;
    using LBL.Data.Models;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Authorization;
    using LBL.Infrastructure;
    using LBL.Services.Articles;
    using LBL.Services.Columnists;

    using static WebConstants;

    public class ArticlesController : Controller
    {
        private readonly IArticleService articles;
        private readonly IColumnistService columnists;
        private readonly LBLDbContext data;

        public ArticlesController(
            IArticleService articles,
            IColumnistService columnists,
            LBLDbContext data)
        {
            this.columnists = columnists;
            this.articles = articles;
            this.data = data;
        }

        public IActionResult All([FromQuery] AllArticlesQueryModel query)
        {
            var queryResult = this.articles.All(
                query.Category,
                query.SearchTerm,
                query.Sorting,
                query.CurrentPage,
                AllArticlesQueryModel.ArticlesPerPage);

            var articleCategories = this.articles.AllArticleCategories();

            query.Categories = articleCategories;
            query.TotalArticles = queryResult.TotalArticles;
            query.Articles = queryResult.Articles;

            return View(query);
        }

        public IActionResult Details(int id)
        {
            var article = this.articles.Details(id);

            return View(article);
        }

        [Authorize]
        public IActionResult MyArticles()
        {
            var myArticles = this.articles.ByAuthor(this.User.GetId());

            return View(myArticles);
        }

        [Authorize]
        public IActionResult Add()
        {
            if(!this.columnists.IsColumnist(this.User.GetId()))
            {
                return RedirectToAction(nameof(ColumnistsController.Become), "Columnists");
            }

            return View(new AddArticleFormModel
            {
                Categories = this.GetArticleCategories()
            });
        }

        [HttpPost]
        [Authorize]
        public IActionResult Add(AddArticleFormModel article)
        {
            var authorId = this.columnists.IdByUser(this.User.GetId());
            var userId = this.User.GetId();

            if(authorId==0)
            {
                return RedirectToAction(nameof(ColumnistsController.Become), "Columnists");
            }

            if (this.data.Regions.Any(c => c.Id == article.CategoryId))
            {
                this.ModelState.AddModelError(nameof(article.CategoryId), "This region doesn't exist");
            }

            if (ModelState.ErrorCount>1)
            {
                article.Categories = this.GetArticleCategories();

                return View(article);
            }

            var articleId = this.articles.Create(
                    article.Title,
                    article.Description,
                    article.Text,
                    article.Image,
                    article.CategoryId,
                    authorId
                );
            TempData[GlobalMessageKey] = "Your article has been added.";

            return RedirectToAction(nameof(All));
        }


        private IEnumerable<ArticleCategoriesViewModel> GetArticleCategories()
            => this.data
            .Categories
            .Select(c => new ArticleCategoriesViewModel
            {
                CategoryId = c.Id,
                Name = c.Name
            })
            .ToList();

        
    }
}
