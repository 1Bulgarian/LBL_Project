namespace LBL.Models.Teams
{
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using static Data.DataConstants;

    public class AddTeamFormModel
    {
        [Required]
        [Display(Name = "Team full name")]
        [StringLength(TeamFullNameMaxLenght, MinimumLength =TeamFullNameMinLenght)]
        public string TeamFullName { get; init; }

        [Required]
        [Display(Name = "Team tag")]
        [StringLength(TeamTagNameMaxLength, MinimumLength = TeamTagNameMinLength)]
        public string TeamTagName { get; init; }

        [Required]
        [Display(Name = "Image URL")]
        [Url]
        public string Logo { get; init; }

        [Required]
        [StringLength(int.MaxValue, MinimumLength =DescriptionMinLength)]
        public string Description { get; init; }

        public string Tier { get; set; }

        public int RegionId { get; init; }

        public IEnumerable<TeamRegionViewModel> CategoriesRegions { get; set; }
    }
}
