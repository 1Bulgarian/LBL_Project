namespace LBL.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using static DataConstants;

    public class Team
    {
        public int Id { get; init; }

        [Required]
        [MaxLength(TeamFullNameMaxLenght)]
        [MinLength(TeamFullNameMinLenght)]
        public string TeamFullName { get; set; }

        [Required]
        [MaxLength(TeamTagNameMaxLength)]
        [MinLength(TeamTagNameMinLength)]
        public string TeamTagName { get; set; }

        [Required]
        public string LogoURL { get; set; }

        [Required]
        [MaxLength(DescriptionMaxLength)]
        public string Description { get; set; }

        public int RegionId { get; set; }

        public Region Region { get; set; }

        public IEnumerable<StaffMember> Members { get; init; } = new List<StaffMember>();

    }
}
