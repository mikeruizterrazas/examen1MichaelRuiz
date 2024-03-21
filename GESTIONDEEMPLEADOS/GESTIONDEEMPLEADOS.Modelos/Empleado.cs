﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GESTIONDEEMPLEADOS.Modelos
{
    public class Empleado
    {
        public int IDEmpleado { get; set; }
        public int IDPersona { get; set; }
        public string Puesto { get; set; }
        public Decimal Salario { get; set; }
        public DateTime FechaContratacion { get; set; }
    }
}
