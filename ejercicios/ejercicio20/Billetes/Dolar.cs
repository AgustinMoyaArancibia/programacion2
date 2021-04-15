using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Dolar
    {
        double cantidad;
        static double cotizRespectoDolar;

         private Dolar()
        {
            cotizRespectoDolar = 1;//siempre 1
        }

        public Dolar(double cantidad) :this()
        {
            this.cantidad = cantidad;
        }

        public Dolar(double cantidad , double cotizacion) : this(cantidad) 
        {
            cotizRespectoDolar = cotizacion;
        }

        public double GetCantidad() 
        {
            return this.cantidad;
        }

        public static double GetCotizacion() 
        {
            return cotizRespectoDolar;
        }
    }
}
