using Microsoft.EntityFrameworkCore;

namespace backend.Extentions
{
    public static class RegisterDatabase
    {
        public static IServiceCollection AddDatabase(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<Context>(options =>
                options.UseSqlServer(configuration.GetConnectionString("Default"),
                b => b.MigrationsAssembly("backend")));
            var build = services.BuildServiceProvider();

            var scope = build.GetService<IServiceScopeFactory>().CreateScope();
            scope.ServiceProvider.GetRequiredService<Context>().Database.Migrate();
            return services;
        }
    }
}
