﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace prueba_proyecto.Models
{
    public class Clientes
    {
        public int Id { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string Direccion { get; set; }
        public int Telefono { get; set; }
        public string Email { get; set; }
    }
}