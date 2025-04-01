using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entities
{
    class DetalleFacturaEntity
    {

        public int cantidad { get; set; }
        public decimal precio { get; set; }
        public decimal total_detalle_factura { get; set; }

        //LLAVES FORANEAS
        public int fkId_factura { get; set; }
        public FacturaEntity factura { get; set; }

        public int fkCodigo_producto { get; set; }
        public ProductoEntity producto { get; set; }

    }
}
