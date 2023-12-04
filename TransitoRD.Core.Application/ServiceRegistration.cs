using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TransitoRD.Core.Application.Interfaces.Services;
using TransitoRD.Core.Application.Services;
using Microsoft.Extensions.Configuration;

namespace TransitoRD.Core.Application
{
   public static class ServiceRegistration
    {
        public static void AddApplicationLayer(this IServiceCollection services, IConfiguration configuration)
        {
            #region Services
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            //services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddTransient<IMultasService, MultasService>();
            services.AddTransient<IMultasTipoService, MultasTipoService>();
            services.AddTransient<IAgenteService, AgenteService>();
            services.AddTransient<IVehiculosService, VehiculosService>();
            services.AddTransient<ILicenciaService, LicenciaService>();
            #endregion
        }
    }
}
