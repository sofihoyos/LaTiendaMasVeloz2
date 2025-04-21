using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using Modelo.Entities;

namespace Logica
{
    class FacturaController
    {
        public string GuardarFactura(int id_factura, DateTime fecha_factura, decimal total_factura, int fkId_persona)
        {
            string resultado;
            BaseDatos db = new BaseDatos();
            int filasInsertadas = db.GuardarFactura(id_factura, fecha_factura, total_factura, fkId_persona);

            if (filasInsertadas > 0)
            {
                resultado = "La factura" + id_factura + "Se ha guardado exitosamente";
            }
            else
            {
                resultado = "La factura" + id_factura + "no se ha guardado exitosamente";
            }
            return resultado;
        }

        public FacturaEntity MostrarFactura()
        {
            BaseDatos db = new BaseDatos();
            FacturaEntity facturaActual = db.MostrarFactura();
            return facturaActual;
        }

        public string ActualizarFactura(int id_factura, DateTime fecha_factura_nueva)
        {
            string resultado;
            BaseDatos db = new BaseDatos();
            int filasAfectadas = db.ActualizarFactura(id_factura, fecha_factura_nueva);

            if (filasAfectadas > 0)
            {
                resultado = "La Factura se actualizó correctamente";
            }
            else
            {
                resultado = "La Factura no pudo actualizar";
            }
            return resultado;
        }

        public string EliminarFactura(int id_factura)
        {
            string resultado;
            BaseDatos db = new BaseDatos();
            int filasAfectadas = db.EliminarPersona(id_factura);

            if (filasAfectadas > 0)
            {
                resultado = "La Persona se eliminó correctamente";
            }
            else
            {
                resultado = "La Persona no se puedo eliminar";
            }
            return resultado;

        }

    }

   
}
