using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entities
{
    class FacturaEntity
    {
        public int id_factura { get; set; }
        public DateTime fecha_factura { get; set; }
        public decimal total_factura { get; set; }

        //LLAVE FORANEA
        public int fkId_persona { get; set; }
        public PersonaEntity persona { get; set; }
    }
}
