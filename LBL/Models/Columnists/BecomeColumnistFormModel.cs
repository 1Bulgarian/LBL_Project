namespace LBL.Models.Columnists
{
    using System.ComponentModel.DataAnnotations;

    public class BecomeColumnistFormModel
    {
        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string LastName { get; set; }
    }
}
