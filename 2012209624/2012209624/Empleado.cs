using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012209624
{
    public class Empleado
    {
        public int IDEmpleado { get; set; }
        public string DNI { get; set; }

        public Empleado()
        {

        }
        public Empleado(String dni)
        {
            DNI = dni;
        }
    }
}
