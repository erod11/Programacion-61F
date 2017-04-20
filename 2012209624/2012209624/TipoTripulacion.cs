using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012209624
{
    public class TipoTripulacion
    {
        private string _tipo;
        public String Tipo
        {
            get
            {
                return _tipo;
            }
            set
            {
                if (value.Length < 0)
                    _tipo = value;
            }
        }
        public TipoTripulacion(string tipo)
        {
            Tipo = tipo;
        }

    }
}
