using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransitoRD.Core.Application.Dtos.Vehiculo
{
    public class RequestVehiculoDto
    {
        [Required(ErrorMessage = "*")]
        [DataType(DataType.Text)]
        public string Placa { get; set; }
        public string Chasis { get; set; }
        public bool estatus { get; set; }
        public string TipoEmision { get; set; }
        public string Tipo_vehiculo { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Fabricacion { get; set; }
        public string Color { get; set; }
        public string Pasajeros { get; set; }
        public string Nombre_Propietario { get; set; }
        public string Cedula_Propietario { get; set; }
        public string Direccion_Propietario { get; set; }
    }
}
