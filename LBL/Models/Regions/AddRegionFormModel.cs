namespace LBL.Models.Regions
{
    using LBL.Data;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using static Data.DataConstants;

    public class AddRegionFormModel
    {
        [Required]
        [Display(Name = "Region's full name")]
        [StringLength(RegionFullNameMaxLength, MinimumLength =RegionFullNameMinLength)]
        public string FullName { get; set; }

        [Required]
        [Display(Name = "Region's short name")]
        [StringLength(RegionShortNameMaxLength, MinimumLength = RegionShortNameMinLength)]
        public string ShortName { get; set; }

        [Required]
        [StringLength(40, MinimumLength =3)]
        public string Location { get; set; }

        [Required]
        [Url]
        [Display(Name = "Region's Logo")]
        public string LogoURL { get; set; }

        [DefaultValue(1)]
        public int Logo { get; set; }

        [Required]
        [StringLength(40, MinimumLength = 3)]
        public string Organizer { get; set; }
    }
}
