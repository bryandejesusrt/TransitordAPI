using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransitoRD.Core.Domain.Common;

namespace TransitoRD.Core.Domain.Entities
{
    public class MultasTipo : AuditableBaseEntity
    {
        public int CodigoMulta { get; set; }

        public String descripcion { get; set; }

        public ICollection<Multas>? multas { get; set; }

    }
}
