using AutoMapper;
using TransitoRD.Core.Application.Dtos.Licencia;
using TransitoRD.Core.Application.Dtos.MultasTipo;
using TransitoRD.Core.Application.Interfaces.Services;
using TransitoRD.Core.Domain.Entities;

namespace TransitoRD.Controllers.v1
{
    public class MultasTipoController : BaseApi<MultasTipo, RequestMultasTipoDto, ResponseMultasTipoDto, IMultasTipoService>
    {
        public MultasTipoController(IMultasTipoService service, IMapper mapper) : base(service, mapper)
        {
        }
    }
}
