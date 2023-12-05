using AutoMapper;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransitoRD.Core.Application.Dtos.Multas;
using TransitoRD.Core.Application.Interfaces.Repositories;
using TransitoRD.Core.Application.Interfaces.Services;
using TransitoRD.Core.Domain.Entities;

namespace TransitoRD.Core.Application.Services
{
    public class MultasService : GenericService<RequestMultasDto, ResponseMultasDto, Multas>, IMultasService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IMapper _mapper;
        private readonly IMultasRepository _imultasRepository;

        public MultasService(IHttpContextAccessor httpContextAccessor, IMapper mapper, IMultasRepository imultasRepository) : base(imultasRepository, mapper)
        {
            _httpContextAccessor = httpContextAccessor;
            _mapper = mapper;
            _imultasRepository = imultasRepository;
        }

        public async Task<List<ResponseMultasDto>> Getmultasbyagente(int id)
        {
            var userList = await _imultasRepository.GetbyAgeneteIdAsync(id);
            return _mapper.Map<List<ResponseMultasDto>>(userList);

        }
    }
}
