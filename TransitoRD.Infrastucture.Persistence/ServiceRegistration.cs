using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TransitoRD.Core.Application.Interfaces.Repositories;
using TransitoRD.Infrastucture.Persistence.Contexts;
using TransitoRD.Infrastucture.Persistence.Repositories;


namespace TransitoRD.Infrastucture.Persistence
{

    //Extension Method - Decorator
    public static class ServiceRegistration
    {
        public static void AddPersistenceInfrastructure(this IServiceCollection services,IConfiguration configuration)
        {
            #region Contexts
            if (configuration.GetValue<bool>("UseInMemoryDatabase"))
            {
                services.AddDbContext<ApplicationContext>(options => options.UseInMemoryDatabase("ApplicationDb"));
            }
            else
            {
                services.AddDbContext<ApplicationContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
                m => m.MigrationsAssembly(typeof(ApplicationContext).Assembly.FullName)));
            }
            #endregion

            #region Repositories
            services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddTransient<IMultasRepository, MultasRepository>();
            services.AddTransient<IVehiculoRepository,VehiculoRepository>();
            services.AddTransient<IAgentesRepository, AgenteRepository>();
            services.AddTransient<IMultasTipoRepository, MultasTipoRepository>();
            services.AddTransient<ILicenciaRepository, LicenciaRepository>();

            #endregion
        }
    }
}
