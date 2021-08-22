namespace LBL.Models.Article
{
    using LBL.Services.Articles;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using static Data.DataConstants;

    public class AddArticleFormModel : IArticleModel
    {
        [Required]
        [Display(Name = "Title")]
        [StringLength(ArticleTitleMaximumLength, MinimumLength = ArticleMinimumLength)]
        public string Title { get; init; }

        [Required]
        [Display(Name = "The article itself")]
        [StringLength(ArticleMaxLength, MinimumLength =ArticleMinimumLength)]
        public string Text { get; init; }

        [Required]
        [Display(Name = "Image URL")]
        [Url]
        public string Image { get; init; }

        [Required]
        [StringLength(int.MaxValue, MinimumLength = DescriptionMinLength)]
        public string Description { get; init; }

        public int CategoryId { get; init; }

        public IEnumerable<ArticleCategoriesViewModel> Categories { get; set; }
    }
}
