using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace API.Model
{
    static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new TnRContext(
                serviceProvider.GetRequiredService<DbContextOptions<TnRContext>>()))
            {
                if (context.Projects.Any()) return;

                context.Projects.Add(
                    new Project
                    {
                        Description = "Newspaper"
                    });

                context.Projects.Add(
                new Project
                {
                    Description = "Publication "
                });

                context.SaveChanges();
            }
        }
    }
}
