using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vallahson.Entities;
using Vallahson.Context;
using Vallahson.Repositories;
using Vallahson.Interfaces;



namespace Vallahson.Configartions
{
    public class BillConfiguration : IEntityTypeConfiguration<Bill>
    {
        public void Configure(EntityTypeBuilder<Bill> builder)
        {
            builder.ToTable("Bill");
            builder.HasKey(b => b.BillId);

        }
    }

    public class BillCustomerConfiguration : IEntityTypeConfiguration<BillCustomer>
    {
        public void Configure(EntityTypeBuilder<BillCustomer> builder)
        {
            builder.ToTable("BillCustomer");
            builder.HasKey(bc => new { bc.BillId, bc.CustomerId });


        }
    }

    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Category");
            builder.HasKey(c => c.CategoryId);


        }
    }

    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customer");
            builder.HasKey(c => c.CustomerId);


        }
    }

    public class ItemConfiguration : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            builder.ToTable("Item");
            builder.HasKey(i => i.ItemId);


        }
    }
}
