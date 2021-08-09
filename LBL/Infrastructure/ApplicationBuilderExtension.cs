namespace LBL.Infrastructure
{
    using System.Linq;
    using LBL.Data;
    using LBL.Data.Models;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;

    public static class ApplicationBuilderExtension
    {
        public static IApplicationBuilder PrepareDatabase (
           this IApplicationBuilder app)
        {
            using var scopedServices = app.ApplicationServices.CreateScope();

            var data = scopedServices.ServiceProvider.GetService<LBLDbContext>();

            data.Database.Migrate();

            SeedRegions(data);

            return app;
        }

        private static void SeedRegions(LBLDbContext data)
        { 
            if(data.Regions.Any())
            {
                return;
            }

            data.Regions.AddRange(new[]
            {
                new Region {FullName="League of Legends European Championship", ShortName="LEC"},
                new Region {FullName="League of Legends Champions Korea", ShortName="LCK"},
                new Region {FullName="League of Legends Professional League", ShortName="LPL"},
            });

            data.SaveChanges();
        }
    }
}