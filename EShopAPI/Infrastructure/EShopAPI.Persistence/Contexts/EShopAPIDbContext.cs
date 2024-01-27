﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EShopAPI.Domain.Entities;
using EShopAPI.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;


namespace EShopAPI.Persistence.Contexts
{
    public class EShopAPIDbContext : DbContext
    {
        public EShopAPIDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var datas = ChangeTracker
                .Entries<BaseEntity>();
            foreach (var data in datas)
            {
                _ = data.State switch
                {
                    EntityState.Added => data.Entity.CreatedDate = DateTime.UtcNow,
                    EntityState.Modified => data.Entity.UpdatedDate = DateTime.UtcNow,
                    _=>DateTime.UtcNow,
                };
            }
            return await base.SaveChangesAsync(cancellationToken);
        }
    }
}