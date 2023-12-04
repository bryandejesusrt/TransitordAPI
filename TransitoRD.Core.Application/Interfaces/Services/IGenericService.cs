using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransitoRD.Core.Application.Interfaces.Services
{
    public interface IGenericService<RequestDto, ResponseDto, Entity>
           where RequestDto : class
           where ResponseDto : class
           where Entity : class
    {
        Task Update(RequestDto vm, int id);

        Task<RequestDto> Add(RequestDto vm);

        Task Delete(int id);

        Task<RequestDto> GetByIdRequest(int id);

        Task<List<ResponseDto>> GetAllResponse();
    }

}
