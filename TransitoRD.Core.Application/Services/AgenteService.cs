using AutoMapper;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransitoRD.Core.Application.Dtos.Agentes;
using TransitoRD.Core.Application.Interfaces.Repositories;
using TransitoRD.Core.Application.Interfaces.Services;
using TransitoRD.Core.Domain.Entities;

namespace TransitoRD.Core.Application.Services
{
    public class AgenteService : GenericService<RequestAgentesDto, ResponseAgentesDto, Agentes>, IAgenteService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IMapper _mapper;
        private readonly IAgentesRepository _iagenteRepository;

        public AgenteService(IHttpContextAccessor httpContextAccessor, IMapper mapper, IAgentesRepository iagenteRepository) : base(iagenteRepository, mapper)
        {
            _httpContextAccessor = httpContextAccessor;
            _mapper = mapper;
            _iagenteRepository = iagenteRepository;
        }

        

    }
}
