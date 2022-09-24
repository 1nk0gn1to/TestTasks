using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class EFProductRepository : IProductRepository
    {
        private readonly MyDBContext context;

        public EFProductRepository(MyDBContext context)
        {
            this.context = context;
        }

        public void DeleteProductById(int id)
        {

            context.Products.Remove(new Product() { Id = id });
            context.SaveChanges();
        }

        public Product GetProductById(int id)
        {
            return context.Products.FirstOrDefault(x => x.Id == id);
        }

        public IQueryable<Product> GetProducts()
        {
            return context.Products;
        }

        public void UpdateProduct(Product product)
        {
            if(product.Id == default)
            {
                context.Entry(product).State = Microsoft.EntityFrameworkCore.EntityState.Added;
            }
            else
            {
                context.Entry(product).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            }
            context.SaveChanges();
        }
    }
}
