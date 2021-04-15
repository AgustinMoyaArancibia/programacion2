using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades19
{
    public class Sumador
    {
        private int cantidadSumas;



        

        public Sumador()
        {
           this.cantidadSumas = 0;
        }

        public Sumador(int cantidadSumas)
            :this() // reutilizo codigo de arriba
        {
            this.cantidadSumas = cantidadSumas;
        }

        public long Sumar(long a, long b) 
        {
            this.cantidadSumas++;
            return a + b;
        }

        public string Sumar(string a , string b)
        {
            this.cantidadSumas++;
            return a + b;
        }

        //public int GetCantidadSumas()
        //{
        //    return this.cantidadSumas;
        //}

        public static explicit operator int(Sumador s)// aca paso cantidad de sumas a int
        {
            return s.cantidadSumas;
        }


        public static long operator +(Sumador s1, Sumador s2) // con el mas lo que hago es sumar dos metodos
        {
            return s1.cantidadSumas + s2.cantidadSumas;
        }

        public static bool operator |(Sumador s1, Sumador s2)
        {
            bool retorno = false;

            if (s1.cantidadSumas == s2.cantidadSumas)
            {
                retorno = true;
            }

            return retorno;
        }
    }
}
