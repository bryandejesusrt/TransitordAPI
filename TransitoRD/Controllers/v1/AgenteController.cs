using Azure.Core;
using Azure;
using TransitoRD.Core.Domain.Entities;
using TransitoRD.Core.Application.Dtos.Agentes;
using TransitoRD.Core.Application.Interfaces.Services;
using AutoMapper;

namespace TransitoRD.Controllers.v1
{
    public class AgenteController : BaseApi<Agentes, RequestAgentesDto, ResponseAgentesDto, IAgenteService>
    {
        public AgenteController(IAgenteService service, IMapper mapper) : base(service, mapper)
        {
        }
    }
}
