using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TransitoRD.Core.Application.Dtos.Licencia;
using TransitoRD.Core.Application.Dtos.Vehiculo;
using TransitoRD.Core.Application.Interfaces.Services;
using TransitoRD.Core.Domain.Entities;

namespace TransitoRD.Controllers.v1
{
    public class VehiculoController : BaseApi<Vehiculos, RequestVehiculoDto, ResponseVehiculoDto, IVehiculosService>
    {
        private IVehiculosService _service;
        public VehiculoController(IVehiculosService service, IMapper mapper) : base(service, mapper)
        {
            _service = service;
        }

        [HttpGet("[Controller]/plate/{placa}")]
        public virtual async Task<IActionResult> GetByPlacaAsync(string placa)
        {
            var entityresult = await _service.GetByplacaRequest(placa);

            if (entityresult is null)
            {
                return NotFound();
            }

            return Ok(entityresult);
        }
    }
}
