using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransitoRD.Core.Domain.Common;

namespace TransitoRD.Core.Domain.Entities
{
    public class Multas : AuditableBaseEntity
    {
        public int AgenteId { get; set; }
        public int CodigoMulta { get; set; }
        public string Motivo { get; set; }
       // public string Fecha_Multa { get; set; }
       // public string Lugar_Infraccion { get; set; }
       // public string Descripcion_Infraccion { get; set; }
        public string Foto { get; set; }
        public string Audio { get; set; }
        public string Longitud { get; set; }
        public string Latitud { get; set; }
        //public double MontoMutal { get; set; }
       // public int PuntosPenalizacion { get; set; }
        public string Placa_Vehiculo { get; set; } = null!;
        //public string Nombre_conductor { get; set; } = null!;
        public string Cedula_infractor { get; set; } = null!;
        public string Fecha { get; set; }
        public string Hora { get; set; }

        public Vehiculos? vehiculos { get; set; }
        public MultasTipo? MultasTipo { get; set; }
        public Agentes? Agente { get; set; }
        public Licencia? Licencia { get; set; }

    }
}
