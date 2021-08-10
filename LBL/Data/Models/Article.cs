namespace LBL.Data.Models
{
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
        public int CategoryId { get; set; }

        public int AuthorId { get; init; }
    }
}
