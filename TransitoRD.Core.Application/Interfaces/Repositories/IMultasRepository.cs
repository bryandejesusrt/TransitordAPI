using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransitoRD.Core.Domain.Entities;

namespace TransitoRD.Core.Application.Interfaces.Repositories
{
    public interface IMultasRepository : IGenericRepository<Multas>
    {
        Task<List<Multas>> GetbyAgeneteIdAsync(int id);
    }
}
