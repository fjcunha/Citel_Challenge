using CitelProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitelProject.Infra.Data.EntityConfig
{
    public class CategoryConfiguration : EntityTypeConfiguration<Category>
    {
        public CategoryConfiguration()
        {
            HasKey(c => c.CategoryID);

            Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(150);

            Property(c => c.Description)
                .IsRequired()
                .HasMaxLength(250);
        }
    }
}
