using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012209624
{
    public class Venta
    {
        private Administrativo _administrativo;
        private Cliente _Cliente;
        private TipoComprobante _TipoComprobante;
        private TipoPago _TipoPago;
        

        public Administrativo Administrativo
        {
            get
            {
                return _administrativo;
            }

        }

        public Cliente Cliente
        {
            get
            {
                return _Cliente;
            }

        }
        public TipoComprobante TipoComprobante
        {
            get
            {
                return _TipoComprobante;
            }

        }
        public TipoPago TipoPago
        {
            get
            {
                return _TipoPago;
            }

        }
        private Servicio _Servicio;

        public Venta(int tipo)
        {
            Tipos = new Servicio(tipo);
        }

        public Servicio Tipos
        {
            get { return _Servicio; }
            set { _Servicio = value; }
        }
    }
}
}
