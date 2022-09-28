using Microsoft.Extensions.DependencyInjection;

namespace ATMDispenseMachine.InfraStructure
{
    public static class DependencyInjectorModule
    {
        public static void ConfigureServices(this IServiceCollection services)
        {
            // services.AddSingleton<ICategoryFactory, CategoryFactory>();
            // services.AddTransient<IConsoleService, ConsoleService>();
            // services.AddTransient<ICategoryService, CategoryService>();
        }
    }
}