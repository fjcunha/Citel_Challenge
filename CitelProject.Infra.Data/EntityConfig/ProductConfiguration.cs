using CitelProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitelProject.Infra.Data.EntityConfig
{
    public class ProductConfiguration : EntityTypeConfiguration<Product>
    {
        public ProductConfiguration()
        {
            HasKey(p => p.ProductID);

            Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(150);

            Property(p => p.Description)
                .IsRequired()
                .HasMaxLength(250);

            HasRequired(p => p.Category)
                .WithMany()
                .HasForeignKey(p => p.CategoryID);
        }
    }
}
