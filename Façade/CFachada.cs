
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subsistemas
{
    class CFachada
    {
        private CSubSistemaCompras compra = new CSubSistemaCompras();
        private CSubSistemaAlmacen almacen = new CSubSistemaAlmacen();
        private CSubSistemaEnvio envio = new CSubSistemaEnvio();

        public void Compra()
        {
            if(compra.Comprar())
            {
                if(almacen.SacarAlmacen())
                {
                    envio.EnviarPedido();
                }
            }
        }
    }
}
