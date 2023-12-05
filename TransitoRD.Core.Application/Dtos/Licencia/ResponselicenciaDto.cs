using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransitoRD.Core.Application.Dtos.Licencia
{
    public class ResponselicenciaDto
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cedula { get; set; }
        public string Foto { get; set; }
        public string Fecha_Nacimiento { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
       // public bool estatus { get; set; }
        public bool HasError { get; set; }
        public string? Error { get; set; }

        //public ICollection<Multas>? multas { get; set; }
    }
}
