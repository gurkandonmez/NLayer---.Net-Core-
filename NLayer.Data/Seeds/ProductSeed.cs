using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Data.Seeds
{
    public class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(new Product
            {
                Id = 1,
                CategoryId = 1,
                Price = 100,
                Stock = 20,
                CreatedDate = DateTime.Now,
                Name = "Kalem 1"
            },
            new Product
            {
                Id = 2,
                CategoryId = 1,
                Price = 200,
                Stock = 20,
                CreatedDate = DateTime.Now,
                Name = "Kalem 2"
            },
            new Product
            {
                Id = 3,
                CategoryId = 1,
                Price = 300,
                Stock = 20,
                CreatedDate = DateTime.Now,
                Name = "Kalem 3"
            },
        new Product
        {
            Id = 1,
            CategoryId = 2,
            Price = 300,
            Stock = 20,
            CreatedDate = DateTime.Now,
            Name = "Defter 1"
        },
           new Product
           {
               Id = 2,
               CategoryId = 2,
               Price = 200,
               Stock = 20,
               CreatedDate = DateTime.Now,
               Name = "Defter 2"
           });
        }
    }
}
