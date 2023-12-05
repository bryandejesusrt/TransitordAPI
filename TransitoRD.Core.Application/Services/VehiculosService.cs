using AutoMapper;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransitoRD.Core.Application.Dtos.Vehiculo;
using TransitoRD.Core.Application.Interfaces.Repositories;
using TransitoRD.Core.Application.Interfaces.Services;
using TransitoRD.Core.Domain.Entities;

namespace TransitoRD.Core.Application.Services
{
    public class VehiculosService : GenericService<RequestVehiculoDto, ResponseVehiculoDto, Vehiculos>, IVehiculosService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IMapper _mapper;
        private readonly IVehiculoRepository _ivehiculoRepository;

        public VehiculosService(IHttpContextAccessor httpContextAccessor, IMapper mapper, IVehiculoRepository ivehiculoRepository) : base(ivehiculoRepository, mapper)
        {
            _httpContextAccessor = httpContextAccessor;
            _mapper = mapper;
            _ivehiculoRepository = ivehiculoRepository;
        }

        public async Task<ResponseVehiculoDto> GetByplacaRequest(string id)
        {
            Vehiculos user = await _ivehiculoRepository.GetByPlacaAsync(id);

            ResponseVehiculoDto vm = _mapper.Map<ResponseVehiculoDto>(user);


            return vm;
        }

       
    }
}
