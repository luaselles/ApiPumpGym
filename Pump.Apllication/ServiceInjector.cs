using MediatR;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace Pump.Apllication
{
    public static class ServiceInjector
    {
        public static IServiceCollection AddAplication(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(ServiceInjector));
            services.AddMediatR(typeof(ServiceInjector));
            services.AddValidatorsFromAssembly(typeof(ServiceInjector).Assembly);
            services.AddScoped(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));
            return services;
        }
    }
}