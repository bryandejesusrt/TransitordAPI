using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransitoRD.Core.Domain.Common;

namespace TransitoRD.Core.Domain.Entities
{
    public class Vehiculos : AuditableBaseEntity
    {
        public string Placa { get; set; } = null!;
        public string Chasis { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Fabricacion { get; set; }
        public string Color { get; set; }
        public int Pasajeros { get; set; }
        public string Nombre_Propietario { get; set; }
        public string Cedula_Propietario { get; set; }
        public string Direccion_Propietario { get; set; }


        public ICollection<Multas>? multas { get; set; }

    }
}
