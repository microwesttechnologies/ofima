
using Infraestructure.PersistenceEFCore.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infraestructure.PersistenceEFCore
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services,
            IConfiguration configuration, string connectionStringName)
        {
            services.AddDbContext<SCRUMContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString(connectionStringName)));

            services.AddScoped<ICreateEmployeeRepository, CreateEmployeeRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IGetAllRepository, GetAllEmployeeRepository>();
            services.AddScoped<IGetEmployeeByIdRepository, GetEmployeeByIdRepository>();
            services.AddScoped<IUpdateEmployeeRepository, UpdateEmployeeRepository>();
            services.AddScoped<IDeleteEmployeeRepository, DeleteEmployeeRepository>();


            return services;
        }
    }
}
