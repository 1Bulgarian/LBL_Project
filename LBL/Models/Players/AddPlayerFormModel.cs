namespace LBL.Models.Players
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using static Data.DataConstants;

    public class AddPlayerFormModel
    {
        [Required]
        [Display(Name = "Player's IGN (In-game nickname)")]
        [StringLength(IGNMaximumLength, MinimumLength = IGNMinimumLength)]
        public string IGN { get; set; }

        [Required]
        [Display(Name = "Player's first name")]
        [StringLength(FirstNameMaximumLength, MinimumLength = FirstNameMinimumLength)]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Player's last name")]
        [StringLength(LastNameMaximumLength, MinimumLength = LastNameMinimumLength)]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Player's last name")]
        [StringLength(CountryOfBirthMaximumLength, MinimumLength = CountryOfBirthMinimumLength)]
        public string CountryOfBirth { get; init; }

        [Required]
        [Display(Name = "Player's image (URL)")]
        [Url]
        public string ImageURL { get; init; }

        [Required]
        [Display(Name = "Player's position")]
        [StringLength(PositionMaximumLength, MinimumLength = PositionMinimumLength)]
        public string Position { get; init; }

        public int TeamId { get; init; }

        public IEnumerable<StaffMembersTeamsViewModel> StaffsTeams { get; set; }
    }
}
