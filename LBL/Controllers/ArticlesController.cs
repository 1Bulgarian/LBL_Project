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

    public class ArticlesController : Controller
    {
        private readonly LBLDbContext data;


        public ArticlesController(LBLDbContext data)
            => this.data = data;


        public IActionResult Add() => View(new AddArticleFormModel
        {
            Categories = this.GetArticleCategories()
        });

        public IActionResult All(int OneCategory, string searchTerm)
        {
            var articlesQuery = this.data.Articles.AsQueryable();

            if(OneCategory != 0)
            {
                articlesQuery = articlesQuery
                    .Where(c => c.CategoryId== OneCategory);
            }

            if(!string.IsNullOrWhiteSpace(searchTerm))
            {
                articlesQuery = articlesQuery.Where(c =>
                    c.Title.ToLower().Contains(searchTerm.ToLower()) ||
                    c.Description.ToLower().Contains(searchTerm.ToLower()) ||
                    c.Category.Name.ToLower().Contains(searchTerm.ToLower()));
            }

            var articles = articlesQuery
                .OrderByDescending(c => c.Id)
                .Select(c => new ArticleListingViewModel
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
            .Select(c => new ArticleCategoriesViewModel
            {
                CategoryId = c.Id,
                Name = c.Name
            })
            .ToList();


            return View(new AllArticlesQueryModel
            {
                ManyCategories = articleCategories,
                Articles = articles,
                SearchTerm = searchTerm
            });
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

            if (!ModelState.IsValid)
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
