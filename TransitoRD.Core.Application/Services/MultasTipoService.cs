using AutoMapper;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransitoRD.Core.Application.Dtos.MultasTipo;
using TransitoRD.Core.Application.Interfaces.Repositories;
using TransitoRD.Core.Application.Interfaces.Services;
using TransitoRD.Core.Domain.Entities;

namespace TransitoRD.Core.Application.Services
{
    public class MultasTipoService : GenericService<RequestMultasTipoDto, ResponseMultasTipoDto, MultasTipo>, IMultasTipoService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IMapper _mapper;
        private readonly IMultasTipoRepository _imultastipoRepository;

        public MultasTipoService(IHttpContextAccessor httpContextAccessor, IMapper mapper, IMultasTipoRepository imultastipoRepository) : base(imultastipoRepository, mapper)
        {
            _httpContextAccessor = httpContextAccessor;
            _mapper = mapper;
            _imultastipoRepository = imultastipoRepository;
        }

        

    }
}
