using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TransitoRD.Core.Application.Dtos.Multas;
using TransitoRD.Core.Application.Interfaces.Services;
using TransitoRD.Core.Domain.Entities;

namespace TransitoRD.Controllers.v1
{
    public class MultasController : BaseApi<Multas, RequestMultasDto, ResponseMultasDto, IMultasService>
    {
        public MultasController(IMultasService service, IMapper mapper) : base(service, mapper)
        {
            _service = service;
        }

        private IMultasService _service;

        [HttpGet("[Controller]/byagente/{id}")]
        public virtual async Task<IActionResult> GetbyAgentAsync(int id)
        {
            var listResult = await _service.Getmultasbyagente(id);
            if (!listResult.Any())
            {
                return NotFound();
            }

            return Ok(listResult);
        }
    }
}
