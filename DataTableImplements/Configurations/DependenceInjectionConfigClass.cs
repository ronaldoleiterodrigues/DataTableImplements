using DataTableImplements.Models.DataSetGrid;

namespace DataTableImplements.Configurations
{
    public static class DependenceInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<GeradorDataSetTest>();
            return services;
        }
    }
}
