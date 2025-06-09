using Domain.Entities;
using Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.SeedData
{
    public class GenerateFakeData
    {
        public static async Task SeedDataAsync(ApplicationDbContext context, ILoggerFactory loggerFactory)
        {
            try
            {
                if (!await context.ProductBrand.AnyAsync())
                {
                    List<ProductBrand> brands = ProductBrands();
                    await context.ProductBrand.AddRangeAsync(brands);
                    await context.SaveChangesAsync();
                }


                if (!await context.ProductType.AnyAsync())
                {
                    List<ProductType> types = ProductTypes();
                    await context.ProductType.AddRangeAsync(types);
                    await context.SaveChangesAsync();
                }

                if (!await context.Products.AnyAsync())
                {
                    List<Product> products = Products();
                    await context.Products.AddRangeAsync(products);
                    await context.SaveChangesAsync();
                }



            }
            catch (Exception e) 
            {
                var logger = loggerFactory.CreateLogger<GenerateFakeData>();
                logger.LogError(e, "error in seed data");
            }
        }

        private static List<ProductBrand> ProductBrands()
        {
            return new List<ProductBrand>()
                    {
                        new()
                        {
                            Description = "Montie’s mother was coming to dinner, so he decided to get out the beautiful dishes she gave him.",
                            Summary = "As Montie stood back to admire his work, the doorbell rang",
                            Title = "brand1"
                        },
                        new()
                        {
                            Description = "Montie’s mother was coming to dinner, so he decided to get out the beautiful dishes she gave him.",
                            Summary = "As Montie stood back to admire his work, the doorbell rang",
                            Title = "brand2"
                        }
                    };
        }
        private static List<ProductType> ProductTypes()
        {
            return new List<ProductType>()
                    {
                        new()
                        {
                            Description = "Montie’s mother was coming to dinner, so he decided to get out the beautiful dishes she gave him.",
                            Summary = "As Montie stood back to admire his work, the doorbell rang",
                            Title = "brand1"
                        },
                        new()
                        {
                            Description = "Montie’s mother was coming to dinner, so he decided to get out the beautiful dishes she gave him.",
                            Summary = "As Montie stood back to admire his work, the doorbell rang",
                            Title = "brand2"
                        }
                    };
        }

        private static List<Product> Products()
        {
            return new List<Product>()
                    {
                        new()
                        {
                            Description = "Montie’s mother was coming to dinner, so he decided to get out the beautiful dishes she gave him.",
                            PictureUrl = "",
                            Price = 15000,
                            Title = "Product 1",
                            Summary = "As Montie stood back to admire his work, the doorbell rang",
                            ProductBrandId = 1,
                            ProductTypeId = 1,
                        },
                         new()
                        {
                            Description = "Montie’s mother was coming to dinner, so he decided to get out the beautiful dishes she gave him.",
                            PictureUrl = "",
                            Price = 15000,
                            Title = "Product 2",
                            Summary = "As Montie stood back to admire his work, the doorbell rang",
                            ProductBrandId = 1,
                            ProductTypeId = 1,
                        },
                          new()
                        {
                            Description = "Montie’s mother was coming to dinner, so he decided to get out the beautiful dishes she gave him.",
                            PictureUrl = "",
                            Price = 15000,
                            Title = "Product 3",
                            Summary = "As Montie stood back to admire his work, the doorbell rang",
                            ProductBrandId = 1,
                            ProductTypeId = 1,
                        },
                           new()
                        {
                            Description = "Montie’s mother was coming to dinner, so he decided to get out the beautiful dishes she gave him.",
                            PictureUrl = "",
                            Price = 15000,
                            Title = "Product 4",
                            Summary = "As Montie stood back to admire his work, the doorbell rang",
                            ProductBrandId = 1,
                            ProductTypeId = 1,
                        },
                            new()
                        {
                            Description = "Montie’s mother was coming to dinner, so he decided to get out the beautiful dishes she gave him.",
                            PictureUrl = "",
                            Price = 15000,
                            Title = "Product 5",
                            Summary = "As Montie stood back to admire his work, the doorbell rang",
                            ProductBrandId = 1,
                            ProductTypeId = 1,
                        }

                    };
        }
    }
}
