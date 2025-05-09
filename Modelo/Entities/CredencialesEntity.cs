﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entities
{
    public class CredencialesEntity
    {
        public int id_credenciales { get; set; } 
        public string usuario { get; set; }
        public string contraseña { get; set; }

        //LLAVE FORANEA
        public int fkId_persona{ get; set; }
        public required PersonaEntity persona { get; set; }
    }
}
