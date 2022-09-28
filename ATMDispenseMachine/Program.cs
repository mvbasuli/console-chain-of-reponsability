using Microsoft.Extensions.DependencyInjection;
using ATMDispenseMachine.InfraStructure;
using System.IO;
using System.Text;
using System;

namespace TradeCategory
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.ConfigureServices();
            var serviceProvider  = serviceCollection.BuildServiceProvider();

            // var categoryService = serviceProvider.GetService<ICategoryService>();

            // if (categoryService != null)
            //     categoryService.CategorizeTrades();
        }
    }
}
