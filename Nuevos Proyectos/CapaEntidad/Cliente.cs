﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string Documento { get; set; }
        public string NombreCompleto { get; set; }
        public string FechaNacimiento { get; set; }
        public string Domicilio { get; set; }
        public string Correo { get; set; }
        public string Curso { get; set; }
        public string Telefono { get; set; }
        public string Sede { get; set; }
        public bool Estado { get; set; }
        public string FechaRegistro { get; set; }

    }
}
