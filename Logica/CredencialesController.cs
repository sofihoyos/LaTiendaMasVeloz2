using Modelo.Entities;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    class CredencialesController
    {
        public string GuardarCredenciales(int id_credenciales, string usuario, string contraseña, int fkId_persona)
        {
            string resultado;
            BaseDatos db = new BaseDatos();
            int filasInsertadas = db.GuardarCredenciales(id_credenciales, usuario, contraseña, fkId_persona);

            if (filasInsertadas > 0)
            {
                resultado = "La categoria " + id_credenciales + "se ha guardado exitosamente";
            }
            else
            {
                resultado = "La categoria " + id_credenciales + "no se ha guardado exitosamente";
            }

            return resultado;
        }

        public List<CredencialesEntity> MostrarCredenciales()
        {
            BaseDatos db = new BaseDatos();
            List<CategoriaEntity> credencialActual = db.MostrarCredenciales();
            return credencialActual;
        }
    }
}
