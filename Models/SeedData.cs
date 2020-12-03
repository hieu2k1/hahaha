using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace Humman.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            StoreDbContext context = app.ApplicationServices
                .CreateScope().ServiceProvider.GetRequiredService<StoreDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Products.Any())
            {
                context.Products.AddRange(                   
                    new Product
                    {
                       ID= 1,
                       Name = "hieuthu1",
                       Old = "19",
                       Img = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRAy9tTbHnlfw8-ZfFCh6-4yFnY9CfDl5XUOw&usqp=CAU",
                       Salary = "100$"
                    },
                    new Product
                    {
                        ID = 2,
                        Name = "hieuthu2",
                        Old = "19",
                        Img = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR1P2aVlP4MP-mG0y7aoedR8ifygijsPCjrNw&usqp=CAU",
                        Salary = "150$"
                    },
                    new Product
                    {
                        ID = 3,
                        Name = "hieuthu3",
                        Old = "19",
                        Img= "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTgorW6KOU1ZHtixMrkvswSvXuwTbyN8Y3kcA&usqp=CAU",
                        Salary = "120$"
                    },
                    new Product
                    {
                        ID = 4,
                        Name = "hieuthu4",
                        Old = "19",
                        Img = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR5VkaWRfgYaVbfeUI2Lcdbz9Fm03gjCc_vBg&usqp=CAU",
                        Salary = "200$"
                    }
                   
                );
                context.SaveChanges();
            }
        }
    }
}
