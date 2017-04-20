using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012209624
{
    public class TipoViaje
    {
        private string _TipoViaje;
        private string Tipo
        {
            get
            {
                return _TipoViaje;
            }
            set
            {
                if (value.Length > 0)
                    _TipoViaje = value;

            }
        }
        public TipoViaje(string tipoViaje)
        {
            Tipo = tipoViaje;
        }
    }
}
