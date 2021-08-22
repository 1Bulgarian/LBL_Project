namespace LBL.Data
{
    public class DataConstants
    {
        //Region and Team
        public const int RegionFullNameMaxLength = 50;
        public const int RegionFullNameMinLength = 1;

        public const int RegionShortNameMaxLength = 5;
        public const int RegionShortNameMinLength = 1;

        public const int RegionLocationMaxLength = 20;

        public const int DescriptionMaxLength = 30000;
        public const int DescriptionMinLength = 10;

        public const int TeamFullNameMaxLenght = 30;
        public const int TeamFullNameMinLenght = 3;

        public const int TeamTagNameMaxLength = 5;
        public const int TeamTagNameMinLength = 2;


        //Article stuff
        public const int ArticleMinimumLength = 10;
        public const int ArticleTitleMinimumLength = 10;
        public const int ArticleTitleMaximumLength = 40;

        public const int DescriptionMinimumLength = 2;
        public const int DescriptionMaximumLength = 175;

        public const int ArticleMaxLength = int.MaxValue;
        public const int ArticleMinLength = 100;

        public const int CategoryNameMinimumLength = 3;



        //Players (NOT Users)
        public const int IGNMinimumLength = 1;
        public const int IGNMaximumLength = 40;

        public const int PositionMinimumLength = 2;
        public const int PositionMaximumLength = 30;

        //Players AND Users
        public const int FirstNameMinimumLength = 2;
        public const int FirstNameMaximumLength = 30;

        public const int LastNameMinimumLength = 3;
        public const int LastNameMaximumLength = 60;

        public const int CountryOfBirthMinimumLength = 4;
        public const int CountryOfBirthMaximumLength = 60;
    }
}
