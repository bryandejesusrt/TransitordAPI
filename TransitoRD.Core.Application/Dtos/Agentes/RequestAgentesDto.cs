using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransitoRD.Core.Application.Dtos.Agentes
{
    public class RequestAgentesDto
    {
        public String nombre { get; set; }
        public String apellido { get; set; }
        public String cedula { get; set; }
        public bool estatus { get; set; }
        public String usuario { get; set; }
        public String clave { get; set; }
    }
}
