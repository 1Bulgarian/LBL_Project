namespace LBL.Infrastructure
{
    using System.Security.Claims;

    public static class ClaimsPrincipalExtensions
    {
        public static string GetId(this ClaimsPrincipal user)
            => user.FindFirst(ClaimTypes.NameIdentifier).Value;

        public static string GetUserName(this ClaimsPrincipal id)
            => id.FindFirst(ClaimTypes.Name).Value;
    }
}
