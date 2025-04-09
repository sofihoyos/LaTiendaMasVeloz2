using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using Modelo.Entities;

namespace Logica
{
    class PersonaController
    {
        public string GuardarPersona(int id_persona, string nombre, string telefono, string correo, TipoPersona tipo_persona)
        {
            string resultado;
            BaseDatos db = new BaseDatos();
            int filasInsertadas = db.GuardarPersona( id_persona, nombre, telefono, correo, tipo_persona);

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

        public PersonaEntity MostrarPersona()
        {
            BaseDatos db = new BaseDatos();
            PersonaEntity personaActual = db.MostrarPersona();
            return personaActual;
        }
    }
}
