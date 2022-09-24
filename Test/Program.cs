using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Test
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            var service = new Services();
            var services = service.ConfigureServices();
            var serviceProvider = services.BuildServiceProvider();

            ApplicationConfiguration.Initialize();
            var form1 = serviceProvider.GetRequiredService<Form1>();
            Application.Run(form1);
        }
        

    }
}