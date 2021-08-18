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

    public class ArticlesController : Controller
    {
        private readonly IArticleService articles;
        private readonly LBLDbContext data;

        public IActionResult Add() => View(new AddArticleFormModel
        {
            Categories = this.GetArticleCategories()
        });

        public ArticlesController(IArticleService articles, LBLDbContext data)
        {

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


        [HttpPost]
        [Authorize]
        public IActionResult Add(AddArticleFormModel article)
        {
            var userId = this.User.GetId();

            if (this.data.Regions.Any(c => c.Id == article.CategoryId))
            {
                this.ModelState.AddModelError(nameof(article.CategoryId), "This region doesn't exist");
            }

            if (ModelState.ErrorCount>1)
            {
                article.Categories = this.GetArticleCategories();

                return View(article);
            }

            var UserId = User.GetId();

            var articleData = new Article
            {
                Title = article.Title,
                Text = article.Text,
                Description = article.Description,
                Image = article.Image,
                CategoryId = article.CategoryId,
                AuthorId = UserId
            };

            this.data.Articles.Add(articleData);
            this.data.SaveChanges();

            return RedirectToAction("Index", "Home");
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
