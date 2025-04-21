using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.Entities;
using Modelo;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Logica
{
    class ProductoController
    {
        public string GuardarProducto(int codigo_producto, string nombre_producto, string descripcion_producto, int stock_producto, int fkCodigo_categoria)
        {
            string resultado;
            BaseDatos db = new BaseDatos();
            int filasInsertadas = db.GuardarPersona(codigo_producto, nombre_producto, descripcion_producto, stock_producto, fkCodigo_categoria);

            if (filasInsertadas > 0)
            {
                resultado = "Guardado";
            }
            else
            {
                resultado = "No guardado";
            }
            return resultado;
        }

        public ProductoEntity MostrarProducto()
        {
            BaseDatos db = new BaseDatos();
            ProductoEntity productoActual = db.MostrarProducto();
            return productoActual;
        }

        public string ActualizarProducto(int codigo_producto, string nombre_producto, string descripcion_producto, int stock_producto, int fkCodigo_categoria)
        {
            string resultado;
            BaseDatos db = new BaseDatos();
            int filasAfectadas = db.ActualizarProducto(codigo_producto, nombre_producto, descripcion_producto, stock_producto, fkCodigo_categoria);

            if (filasAfectadas > 0)
            {
                resultado = "La Persona se actualizó correctamente";
            }
            else
            {
                resultado = "La Persona pudo actualizar";
            }
            return resultado;
        }

        public string EliminarProducto(int codigo_producto)
        {
            string resultado;
            BaseDatos db = new BaseDatos();
            int filasAfectadas = db.EliminarProducto(codigo_producto);

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
