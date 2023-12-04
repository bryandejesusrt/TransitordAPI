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
    public class LicenciaRepository : GenericRepository<Licencia>, ILicenciaRepository
    {
        private readonly ApplicationContext _dbContext;

        public LicenciaRepository(ApplicationContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }



    }
}
