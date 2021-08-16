namespace LBL.Controllers
{
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
        private readonly UserManager<LBLDbContext> _userManager;


        public ArticlesController(LBLDbContext data)
            => this.data = data;


        public IActionResult Add() => View(new AddArticleFormModel
        {
            Categories = this.GetArticleCategories()
        });

        public IActionResult All()
        {
            var articles = this.data
                .Articles
                .OrderByDescending(c => c.Id)
                .Select(c => new ArticleListViewModel
                {
                    Id = c.Id,
                    Title = c.Title,
                    Description = c.Description,
                    Text = c.Text,
                    Image = c.Image,
                    Category = c.Category.Name,
                    AuthorId = c.AuthorId
                })
                .ToList();

            return View(articles);
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

            if (ModelState.Count < 4)
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
