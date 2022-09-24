using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Services
    {
        public IServiceCollection ConfigureServices()
        {
            var services = new ServiceCollection();
            services.AddScoped<Form1>();
            services.AddTransient<IProductRepository, EFProductRepository>();
            services.AddDbContext<MyDBContext>(x => x.UseSqlServer(@"Server = (LocalDB)\MSSQLLocalDB; Database = test; Trusted_Connection = true"));

            return services;
        }
    }
}
