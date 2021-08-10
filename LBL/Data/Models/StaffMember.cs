namespace LBL.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using static Data.DataConstants;

    public class StaffMember
    {
        public int Id { get; init; }

        [Required]
        [StringLength(IGNMaximumLength, MinimumLength = IGNMinimumLength)]
        public string IGN { get; set; }

        [Required]
        [StringLength(FirstNameMaximumLength, MinimumLength =FirstNameMinimumLength)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(LastNameMaximumLength, MinimumLength =LastNameMinimumLength)]
        public string LastName { get; set; }

        [Required]
        [StringLength(CountryOfBirthMaximumLength, MinimumLength =CountryOfBirthMinimumLength)]
        public string CountryOfBirth { get; init; }

        [Required]
        public string ImageURL { get; set; }

        [Required]
        [StringLength(PositionMaximumLength, MinimumLength =PositionMinimumLength)]
        public string Position { get; set; }

        public int TeamId { get; set; }

        public Team Team { get; set; }
    }
}
