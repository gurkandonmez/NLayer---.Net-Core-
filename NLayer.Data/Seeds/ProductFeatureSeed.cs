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
    public class ProductFeatureSeed : IEntityTypeConfiguration<ProductFeature>
    {
  

        public void Configure(EntityTypeBuilder<ProductFeature> builder)
        {
            builder.HasData(new ProductFeature
            {
                Id = 1,
                ProductId = 1,
                Width = 20,
                Height = 30,
                Color = "Kırmızı"

            },
             new ProductFeature
             {
                 Id = 2,
                 ProductId = 2,
                 Width = 20,
                 Height = 30,
                 Color = "Pembe"

             },
             new ProductFeature
             {
                 Id = 3,
                 ProductId = 3,
                 Width = 20,
                 Height = 30,
                 Color = "Mavi"

             },
        new ProductFeature
        {
            Id = 4,
            ProductId = 4,
            Width = 20,
            Height = 30,
            Color = "Pembe"

        });
        }
    }
}
