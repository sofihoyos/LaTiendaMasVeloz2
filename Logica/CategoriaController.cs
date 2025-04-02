using Modelo;
using Modelo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    class CategoriaController
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
    }
}
