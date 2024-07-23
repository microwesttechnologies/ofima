using Application.Service;
using Infraestructure.PersistenceEFCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace infraestructure.IoC
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddSCRUM(this IServiceCollection services,
            IConfiguration configuration, string connectionStringName) 
        {
            services.AddAplicationServices()
                    .AddPersistence(configuration, connectionStringName);
            
            return services;
        }
    }
}
