namespace LBL.Data.Models
{
    using System;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using static DataConstants;

    public class Article
    {
        public int Id { get; init; }

        [Required]
        [MinLength(ArticleTitleMinimumLength)]
        public string Title { get; set; }

        [Required]
        [MinLength(ArticleMinimumLength)]
        public string Text { get; set; }

        [Required]
        public Category Category { get; set; }

        [Required]
        public string Description { get; init; }

        [Required]
        public int CategoryId { get; set; }

        public string Image { get; init; }

        public string AuthorId { get; init; }
    }
}
