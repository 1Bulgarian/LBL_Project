namespace LBL.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using static DataConstants;

    public class Region
    {
        public int Id { get; init; }

        [Required]
        [MaxLength(RegionFullNameMaxLength)]
        public string FullName { get; set; }

        [Required]
        [MaxLength(RegionShortNameMaxLength)]
        public string ShortName { get; set; }

        public string Location { get; set; }

        public string LogoUrl { get; set; }

        [Required]
        public string Organizer { get; set; }

        public IEnumerable<Team> Teams { get; init; } = new List<Team>();
    }
}
