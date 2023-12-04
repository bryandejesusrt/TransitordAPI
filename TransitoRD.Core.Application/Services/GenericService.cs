using AutoMapper;
using TransitoRD.Core.Application.Interfaces.Repositories;
using TransitoRD.Core.Application.Interfaces.Services;
using TransitoRD.Core.Domain.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace TransitoRD.Core.Application.Services
{
    public class GenericService<Request, Response,Entity> : IGenericService<Request, Response, Entity>
        where Request : class
        where Response : class
        where Entity : class
    {
        private readonly IGenericRepository<Entity> _repository;
        private readonly IMapper _mapper;

        public GenericService(IGenericRepository<Entity> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        
        public virtual async Task Update(Request vm,int id)
        {
            Entity entity = _mapper.Map<Entity>(vm);

            await _repository.UpdateAsync(entity,id);
        }

        public virtual async Task<Request> Add(Request vm)
        {
            Entity entity = _mapper.Map<Entity>(vm);
            entity = await _repository.AddAsync(entity);
            Request svm = _mapper.Map<Request>(entity);

            return svm;
        }

        public virtual async Task Delete(int id)
        {
            Entity entity = await _repository.GetByIdAsync(id);
            await _repository.DeleteAsync(entity);
        }

        public virtual async Task<Request> GetByIdRequest(int id)
        {
            Entity user = await _repository.GetByIdAsync(id);

            Request vm = _mapper.Map<Request>(user);


            return vm;

        }

        public virtual async Task<List<Response>> GetAllResponse()
        {
            var userList = await _repository.GetAllAsync();
            return _mapper.Map<List<Response>>(userList);

        }

        public virtual async Task<Response> GetByIdResponse(int id)
        {
            var user = await _repository.GetByIdAsync(id);

            return _mapper.Map<Response>(user);

        }

      
    }
}
