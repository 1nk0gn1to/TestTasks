using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class MyDBContext : DbContext
    {
        public MyDBContext(DbContextOptions <MyDBContext> options) : base(options) 
        { 
            base.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking; 
        }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder model)
        {
            base.OnModelCreating(model);

            model.Entity<Product>().HasData(new Product  { 
                Id = 1,
                ProductName = "Шаурма", 
                Info = "В состав входят:", 
                Price = 170 
            });
        }
    }
}
