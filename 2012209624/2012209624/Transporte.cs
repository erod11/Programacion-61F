using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012209624
{
    public class Transporte
    {
        private LugarViaje _lugar;
        private TipoViaje _tipo;
        private Cliente _cliente;

        public Transporte(int tipo) : base(tipo)
        {
        }

        public LugarViaje LugarViaje
        {
            get
            {
                return _lugar;
            }
        }
        public TipoViaje TipoViaje
        {
            get
            {
                return _tipo;
            }
        }
        public Cliente Cliente { get { return _cliente; } }


        public override void tipoServicio(int tipo)
        {
            if (tipo == 001)
            {
                Console.WriteLine("El servicio seleccionado es transporte");
            }
        }
    }
}
