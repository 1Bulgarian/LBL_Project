namespace LBL.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using static DataConstants;

    public class Category
    {
        public int Id { get; init; }

        [Required]
        [MinLength(CategoryNameMinimumLength)]
        public string Name { get; init; }

        public IEnumerable<Article> Articles { get; init; } = new List<Article>();
    }
}
