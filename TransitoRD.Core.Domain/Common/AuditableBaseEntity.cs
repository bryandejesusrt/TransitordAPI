using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransitoRD.Core.Domain.Common
{
    public class AuditableBaseEntity
    {

        public virtual int Id { get; set; }
        public string? CreadoPor { get; set; }
        public DateTime? Creacion { get; set; }
        public string? UltimaModificaionPor { get; set; }
        public DateTime? UltimaModificaio { get; set; }
    }
}
