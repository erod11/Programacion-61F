using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012209624
{
    public class Encomienda
    {
        private Encomienda _encomienda;

        public Encomienda(int tipo) : base(tipo)
        {
        }

        public Encomienda encomienda
        {
            get
            {
                return _encomienda;
            }
        }

        public override void tipoServicio(int tipo)
        {
            if (tipo == 002)
            {
                Console.WriteLine("El servicio seleccionado es Encomienda");
            }
        }
    }
}
