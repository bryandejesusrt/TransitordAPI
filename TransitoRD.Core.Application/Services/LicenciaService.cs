using AutoMapper;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransitoRD.Core.Application.Dtos.Licencia;
using TransitoRD.Core.Application.Interfaces.Repositories;
using TransitoRD.Core.Application.Interfaces.Services;
using TransitoRD.Core.Domain.Entities;

namespace TransitoRD.Core.Application.Services
{
    public class LicenciaService : GenericService<RequestlicenciaDto, ResponselicenciaDto, Licencia>, ILicenciaService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IMapper _mapper;
        private readonly ILicenciaRepository _ilicenciaRepository;

        public LicenciaService(IHttpContextAccessor httpContextAccessor, IMapper mapper, ILicenciaRepository ilicenciaRepository) : base(ilicenciaRepository, mapper)
        {
            _httpContextAccessor = httpContextAccessor;
            _mapper = mapper;
            _ilicenciaRepository = ilicenciaRepository;
        }

        

    }
}
