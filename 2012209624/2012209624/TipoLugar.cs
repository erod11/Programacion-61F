using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012209624
{
   public class TipoLugar
    {
        private string _TipoLugar;
        private string Tipo
        {
            get
            {
                return _TipoLugar;
            }
            set
            {
                if (value.Length > 0)
                    _TipoLugar = value;

            }
        }
        public TipoLugar(string tipoViaje)
        {
            Tipo = _TipoLugar;
        }
    }
}
