using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransitoRD.Core.Domain.Common;

namespace TransitoRD.Core.Domain.Entities
{
    public class Licencia : AuditableBaseEntity
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cedula { get; set; } = null!;
        public string Foto { get; set; }
        public string Fecha_Nacimiento { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        //public bool estatus { get; set; }

        public ICollection<Multas>? multas { get; set; }

        public Licencia() {
            multas = new List<Multas>();
        }
    }
}
