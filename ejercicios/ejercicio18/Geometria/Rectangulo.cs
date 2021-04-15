using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    public class Rectangulo
    {
        private float area;
        private float perimetro;
        private Punto vertice1;
        private Punto vertice2;
        private Punto vertice3;
        private Punto vertice4;


        public Rectangulo(Punto verticeUno,Punto verticeTres)
        {
            this.vertice1 = Math.Abs(verticeUno);
            this.vertice3 = verticeTres;

            
        }
        
    }
}
