using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransitoRD.Core.Application.Dtos.Agentes;
using TransitoRD.Core.Application.Dtos.Licencia;
using TransitoRD.Core.Application.Dtos.Multas;
using TransitoRD.Core.Domain.Entities;

namespace TransitoRD.Core.Application.Interfaces.Services
{
        public interface ILicenciaService : IGenericService<RequestlicenciaDto, ResponselicenciaDto, Licencia>
        {

        }
    }

