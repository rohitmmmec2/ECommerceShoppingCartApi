using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Infrastructure.EFCore
{
    public static class DbInitializer
    {
        public static void Initialize(ProductDbContext dbContext)
        {
            dbContext.Database.EnsureCreated();
            if(dbContext.Products.Any())
            {
                return;
            }

            var products = new Product[]
            {
                new Product { CompanyName= "ADIDAS", Image= "images/4.jpg", CurrentPrice=999, OriginalPrice=1200, DiscountPercentage=10, FastDelivery=true, InStock=true, ProductName="Indian Cricket ODI Jersey", Ratings = "4.3"},
                new Product { CompanyName= "Roadster", Image= "images/5.jpg", CurrentPrice=489, OriginalPrice=1399, DiscountPercentage=65, FastDelivery=true, InStock=true, ProductName="Pure Cotton T-shirt", Ratings = "4.9"},
            };

            foreach(var product in products)
            {
                dbContext.Products.Add(product);
            }
            dbContext.SaveChanges();
        }
    }
}
