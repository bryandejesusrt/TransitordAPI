using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TransitoRD.Core.Application.Interfaces.Services;
using TransitoRD.Core.Application.Services;

namespace TransitoRD.Controllers
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class BaseApi<Entity, request, reponse, IService> : ControllerBase
        where Entity : class
        where request : class
        where reponse : class
        where IService : IGenericService<request,reponse, Entity>

    {
        private readonly IService _service;
        private readonly IMapper _mapper;

        public BaseApi(IService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet($"[controller]s")]
        public virtual async Task<IActionResult> GetAllAsync()
        {
            var listResult = await _service.GetAllResponse();
            if (!listResult.Any())
            {
                return NotFound();
            }

            return Ok(listResult);
        }
        //[HttpGet("[controller]s/{pagina}/{cantidad}")]
        //public virtual async Task<IActionResult> GetAllAsync(int pagina = 0, int cantidad = 10)
        //{
        //    var listResult = await _service.GetAllResponse();
        //    if (!listResult.Any())
        //    {
        //        return NotFound();
        //    }

        //    return Ok(listResult);
        //}

        //[HttpPost("[Controller]/Activar/{id}")]
        //public virtual async Task<IActionResult> Activate(int id)
        //{
        //    await _service.ActivateEntity(id);

        //    return Ok();
        //}
        [HttpPost($"[Controller]")]
        public virtual async Task<IActionResult> PostAsync(request input)
            => Created("", await _service.Add(input));

        [HttpGet("[Controller]/{id}")]
        public virtual async Task<IActionResult> GetByIdAsync(int id)
        {
            var entityresult = await _service.GetByIdRequest(id);

            if (entityresult is null)
            {
                return NotFound();
            }

            return Ok(entityresult);
        }

        //[HttpPut($"[Controller]")]
        //public virtual async Task<IActionResult> Update(reponseUpdate input)
        //    => Ok(await _service.UpdateAsync(input));

        [HttpDelete("[Controller]/{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            await _service.Delete(id);
            return Ok();
        }

    }
}
