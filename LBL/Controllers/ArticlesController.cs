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

        public IActionResult All([FromQuery]AllArticlesQueryModel query)
            //int OneCategory, 
            //string SearchTerm, 
            //ArticleSorting Sorting
            //)
        {
            var articlesQuery = this.data.Articles.AsQueryable();

            if(!string.IsNullOrWhiteSpace(query.OneCategory))
            {
                articlesQuery = articlesQuery
                    .Where(c => c.Category.Name== query.OneCategory);
            }

            if(!string.IsNullOrWhiteSpace(query.SearchTerm))
            {
                articlesQuery = articlesQuery.Where(c =>
                    c.Title.ToLower().Contains(query.SearchTerm.ToLower()) ||
                    c.Description.ToLower().Contains(query.SearchTerm.ToLower()) ||
                    c.Category.Name.ToLower().Contains(query.SearchTerm.ToLower()));
            }

            articlesQuery = query.Sorting switch
            {
                ArticleSorting.AtoZ => articlesQuery.OrderBy(c=>c.Title),
                ArticleSorting.ZtoA => articlesQuery.OrderByDescending(c=>c.Title),
                ArticleSorting.DatePublishedDesc => articlesQuery.OrderBy(c=>c.Id),
                ArticleSorting.DatePublished or _=> articlesQuery.OrderByDescending(c=>c.Id)

            };

            var articles = articlesQuery
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
                SearchTerm = query.SearchTerm,
                Sorting = query.Sorting
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
