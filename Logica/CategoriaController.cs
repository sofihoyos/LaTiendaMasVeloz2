using Modelo;
using Modelo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class CategoriaController
    {
        public string GuardarCategoria(int codigo_categoria, string nombre_categoria)
        {
            string resultado;
            BaseDatos db = new BaseDatos();
            int filasInsertadas = db.GuardarCategoria(codigo_categoria, nombre_categoria);

            if (filasInsertadas > 0)
            {
                resultado = "La categoria " + nombre_categoria + "se ha guardado exitosamente";
            }
            else
            {
                resultado = "La categoria " + nombre_categoria + "no se ha guardado exitosamente";
            }

            return resultado;
        }

        public List<CategoriaEntity> MostrarCategorias()
        {
            BaseDatos db = new BaseDatos();
            List<CategoriaEntity> categoriaActual = db.MostrarCategorias();
            return categoriaActual;
        }


        public string ActualizarCategoria(int codigo_categoria, string nuevo_nombre)
        {
            string resultado;
            BaseDatos db = new BaseDatos();
            int filasAfectadas = db.ActualizarCategoria(codigo_categoria, nuevo_nombre);

            if (filasAfectadas > 0)
            {
                resultado = "La categoría se actualizó correctamente.";
            }
            else
            {
                resultado = "No se pudo actualizar la categoría.";
            }

            return resultado;
        }

        public string EliminarCategoria(int codigo_categoria)
        {
            string resultado;
            BaseDatos db = new BaseDatos();
            int filasAfectadas = db.EliminarCategoria(codigo_categoria);

            if (filasAfectadas > 0)
            {
                resultado = "La categoría se eliminó correctamente.";
            }
            else
            {
                resultado = "No se pudo eliminar la categoría.";
            }

            return resultado;
        }

    }
}
