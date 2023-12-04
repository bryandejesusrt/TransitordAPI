using TransitoRD.Core.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransitoRD.Core.Domain.Entities
{
    public class Agentes : AuditableBaseEntity
    {

        public String nombre { get; set; }
        public String apellido { get; set; }
        public String cedula { get; set; } = null!;
        public bool estatus { get; set; }
        public String usuario { get; set; }
        public String clave { get; set; }

        public int multasId { get; set; }
        public ICollection<Multas>? multas { get; set; }


        public Agentes() {
            multas = new List<Multas>();
        }
    }
}
