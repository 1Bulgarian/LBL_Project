namespace LBL.Services.Teams.Models
{
    public class TeamStaffMemberServiceModel
    {
        public int Id { get; init; }

        public string IGN { get; init; }

        public string FirstName { get; init; }

        public string LastName { get; init; }

        public string CountryOfBirth { get; init; }

        public string ImageURL { get; init; }

        public string Position { get; init; }

        public int TeamId { get; init; }
    }
}
