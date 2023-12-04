using AutoMapper;
using TransitoRD.Core.Application.Dtos.Agentes;
using TransitoRD.Core.Application.Dtos.Licencia;
using TransitoRD.Core.Application.Interfaces.Services;
using TransitoRD.Core.Domain.Entities;

namespace TransitoRD.Controllers.v1
{
    public class LicenciaController : BaseApi<Licencia, RequestlicenciaDto, ResponselicenciaDto, ILicenciaService>
    {
        public LicenciaController(ILicenciaService service, IMapper mapper) : base(service, mapper)
        {
        }
    }
}
