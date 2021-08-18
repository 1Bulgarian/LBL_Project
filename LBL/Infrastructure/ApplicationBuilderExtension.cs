namespace LBL.Infrastructure
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using LBL.Data;
    using LBL.Data.Models;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;

    using static WebConstants;

    public static class ApplicationBuilderExtension
    {
        public static IApplicationBuilder PrepareDatabase (
           this IApplicationBuilder app)
        {
            using var serviceScope = app.ApplicationServices.CreateScope();
            var services = serviceScope.ServiceProvider;

            MigrateDatabase(services);

            SeedRegions(services);
            SeedAdministrator(services);

            return app;
        }

        private static void MigrateDatabase(IServiceProvider services)
        {
            var data = services.GetRequiredService<LBLDbContext>();

            data.Database.Migrate();
        }

        private static void SeedRegions(IServiceProvider services)
        {
            var data = services.GetRequiredService<LBLDbContext>();
            if (data.Regions.Any())
            {
                return;
            }

            data.Regions.AddRange(new[]
            {
                new Region {
                    FullName="League of Legends European Championship", 
                    ShortName="LEC",
                    Location="Europe",
                    LogoUrl="",
                    Organizer="Riot Games"
                },
                new Region {
                    FullName="League of Legends Champions Korea",
                    ShortName="LCK",
                    Location="Korea",
                    LogoUrl="",
                    Organizer="Riot Games"
                },
                new Region {
                    FullName="League of Legends Professional League",
                    ShortName="LPL",
                    Location="China",
                    LogoUrl="",
                    Organizer="TJ Esports"
                },
            });

            data.SaveChanges();
        }

        private static void SeedAdministrator(IServiceProvider services)
        {
            var userManager = services.GetRequiredService<UserManager<User>>();
            var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();

            Task
                .Run(async () =>
                {
                    if (await roleManager.RoleExistsAsync(AdministratorRoleName))
                    {
                        return;
                    }

                    var role = new IdentityRole { Name = AdministratorRoleName };

                    await roleManager.CreateAsync(role);

                    const string adminEmail = "admin@admin.com";
                    const string adminPassword = "admin12";

                    var user = new User
                    {
                        Email = adminEmail,
                        UserName = "Admin"
                    };

                    await userManager.CreateAsync(user, adminPassword);

                    await userManager.AddToRoleAsync(user, role.Name);
                })
                .GetAwaiter()
                .GetResult();
        }

    }
}