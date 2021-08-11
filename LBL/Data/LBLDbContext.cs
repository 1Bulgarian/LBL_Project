namespace LBL.Data
{
    using LBL.Data.Models;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    public class LBLDbContext : IdentityDbContext<User>
    {
        public LBLDbContext(DbContextOptions<LBLDbContext> options)
            : base(options)
        {
        }
        
        public DbSet<Team> Teams { get; init; }

        public DbSet<Region> Regions { get; init; }

        public DbSet<Article> Articles { get; init; }

        public DbSet<Category> Categories { get; init; }

        public DbSet<StaffMember> StaffMembers { get; init; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
                .Entity<Team>()
                .HasOne(c => c.Region)
                .WithMany(c => c.Teams)
                .HasForeignKey(c => c.RegionId)
                .OnDelete(DeleteBehavior.Restrict);
            builder
                .Entity<Article>()
                .HasOne(r => r.Category)
                .WithMany(r => r.Articles)
                .HasForeignKey(r => r.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);
            builder
                .Entity<StaffMember>()
                .HasOne(c => c.Team)
                .WithMany(c => c.Members)
                .HasForeignKey(c => c.TeamId)
                .OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(builder);
        }
    }
}
