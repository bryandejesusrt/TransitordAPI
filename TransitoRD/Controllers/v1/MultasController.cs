using AutoMapper;
using TransitoRD.Core.Application.Dtos.Multas;
using TransitoRD.Core.Application.Interfaces.Services;
using TransitoRD.Core.Domain.Entities;

namespace TransitoRD.Controllers.v1
{
    public class MultasController : BaseApi<Multas, RequestMultasDto, ResponseMultasDto, IMultasService>
    {
        public MultasController(IMultasService service, IMapper mapper) : base(service, mapper)
        {
        }
    }
}
