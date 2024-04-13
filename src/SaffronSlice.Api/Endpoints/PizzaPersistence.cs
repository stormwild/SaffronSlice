using SaffronSlice.Core.Repositories;
using SaffronSlice.Infrastructure.Repositories;

namespace SaffronSlice.Api;

public static class PizzaPersistence
{
    public static void AddPizzaRepository(this IServiceCollection services)
    {
        services.AddScoped<IRepository<Pizza>, PizzaRepository>();
    }

}
