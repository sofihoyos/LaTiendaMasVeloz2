using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entities
{
    class ProductoEntity
    {
        public int codigo_producto { get; set; }

        public string nombre_producto { get; set; }

        public string descripcion_producto { get; set; }
        public decimal precio { get; set; }
        public int stock_producto { get; set; }


        //LLAVE FORANEA
        public int fkCodigo_categoria { get; set; }
        public CategoriaEntity categoria { get; set; }

   

    }
}
