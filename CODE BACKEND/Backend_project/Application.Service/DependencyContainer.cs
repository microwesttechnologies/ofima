using Application.Service.EmployeeFeature.Commands.CreateEmployee;
using Application.Service.EmployeeFeature.Commands.DeleteEmployee;
using Application.Service.EmployeeFeature.Commands.UpdateEmployee;
using Application.Service.EmployeeFeature.Queries.GetAllEmployee;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Application.Service
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddAplicationServices(this IServiceCollection services)
        {
            services.AddMediatR(cfg =>
            cfg.RegisterServicesFromAssembly(typeof(CreateEmployeeCommand).Assembly));

            services.AddMediatR(cfg =>
            cfg.RegisterServicesFromAssembly(typeof(GetAllEmployeeQuery).Assembly));
            
            services.AddMediatR(cfg =>
            cfg.RegisterServicesFromAssembly(typeof(UpdateEmployeeCommand).Assembly)); 
            
            services.AddMediatR(cfg =>
            cfg.RegisterServicesFromAssembly(typeof(DeleteEmployeeCommand).Assembly));

            services.AddMediatR(cfg =>
            cfg.RegisterServicesFromAssembly(typeof(GetAllMenu).Assembly));

            return services;
        }
    }
}
