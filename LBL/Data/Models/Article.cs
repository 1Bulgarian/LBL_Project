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
        [StringLength(ArticleTitleMaximumLength, MinimumLength = ArticleTitleMinimumLength)]
        public string Title { get; set; }

        [Required]
        public string Text { get; set; }

        [Required]
        public Category Category { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public int CategoryId { get; set; }

        public string Image { get; set; }

        public int AuthorId { get; init; }

        public Columnist Author { get; init; }
    }
}
