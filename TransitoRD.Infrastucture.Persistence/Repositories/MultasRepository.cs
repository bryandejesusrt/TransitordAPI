using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransitoRD.Core.Application.Interfaces.Repositories;
using TransitoRD.Core.Domain.Entities;
using TransitoRD.Infrastucture.Persistence.Contexts;

namespace TransitoRD.Infrastucture.Persistence.Repositories
{
    public class MultasRepository : GenericRepository<Multas>, IMultasRepository
    {
        private readonly ApplicationContext _dbContext;

        public MultasRepository(ApplicationContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public virtual async Task<List<Multas>> GetbyAgeneteIdAsync(int id)
        {
            var temp =  await _dbContext.Set<Multas>().ToListAsync();

            return temp.Where(x => x.AgenteId == id).ToList();
        }



    }
}
