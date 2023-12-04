using AutoMapper;
using TransitoRD.Core.Application.Dtos.Licencia;
using TransitoRD.Core.Application.Dtos.Vehiculo;
using TransitoRD.Core.Application.Interfaces.Services;
using TransitoRD.Core.Domain.Entities;

namespace TransitoRD.Controllers.v1
{
    public class VehiculoController : BaseApi<Vehiculos, RequestVehiculoDto, ResponseVehiculoDto, IVehiculosService>
    {
        public VehiculoController(IVehiculosService service, IMapper mapper) : base(service, mapper)
        {
        }
    }
}
