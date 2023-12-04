using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransitoRD.Core.Application.Dtos.Multas;

namespace TransitoRD.Core.Application.Dtos.MultasTipo
{
    public class ResponseMultasTipoDto
    {
        public int CodigoMulta { get; set; }

        public String descripcion { get; set; }
        public bool HasError { get; set; }
        public string? Error { get; set; }

        public List<ResponseMultasDto>? Multas { get; set; }

        public ResponseMultasTipoDto()
        {
            Multas = new List<ResponseMultasDto>();
        }
    }
}
