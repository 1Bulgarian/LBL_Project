namespace LBL.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Columnist
    {
        public int Id { get; init; }

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        [Required]
        public string UserId { get; set; }

        public IEnumerable<Article> Articles { get; init; } = new List<Article>();
    }
}
