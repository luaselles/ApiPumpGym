using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Pump.Domain.Interfaces;
using Pump.Infra.Data.Repository;

namespace Pump.Infra.Data
{
    public static class ServiceInjector
    {
        /// <summary>
        /// Tabela de Configurações string de conexão
        /// </summary>
        /// <param name="services"></param>
        /// <param name="connectionString"></param>
        /// <returns></returns>
        public static IServiceCollection AddInfraData(this IServiceCollection services, string? connectionString)
        {
           services.AddDbContext<ElementoPumpDBContext>(op => op.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString))); 
           
           services.AddTransient<IRepository, ElementoPumpRepository>();
           return services;
        }
    }
}