using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransitoRD.Core.Application.Dtos.Agentes;
using TransitoRD.Core.Application.Dtos.Multas;
using TransitoRD.Core.Application.Dtos.MultasTipo;
using TransitoRD.Core.Application.Dtos.Vehiculo;
using TransitoRD.Core.Domain.Entities;

namespace TransitoRD.Core.Application.Interfaces.Services
{
        public interface IVehiculosService : IGenericService<RequestVehiculoDto, ResponseVehiculoDto, Vehiculos>
        {
        Task<ResponseVehiculoDto> GetByplacaRequest(string id);

    }
    }

