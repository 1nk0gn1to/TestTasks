using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public interface IProductRepository
    {
        IQueryable<Product> GetProducts();
        Product GetProductById(int id);
        void DeleteProductById(int id);
        void UpdateProduct(Product product);
    }
}
