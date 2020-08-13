using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subsistemas
{
    class CSubSistemaCompras
    {
        public bool Comprar()
        {
            string dato = "";
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Introducir Numero de tarjeta");
            dato = Console.ReadLine();

            if(dato == "12345")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Pago aceptado");
                return true;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Pago rechazado");
                return false;
            }
        }
    }

    class CSubSistemaAlmacen
    {
        private int cantidad;

        public CSubSistemaAlmacen()
        {
            cantidad = 3;
        }

        public bool SacarAlmacen()
        {
            if(cantidad > 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Producto listo para enviarse");
                cantidad--;
                return true;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Producto no disponible");
                return false;
            }
        }

    }
    class CSubSistemaEnvio
    {
        public void EnviarPedido()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("El envio va en camino");
        }
    }
}
