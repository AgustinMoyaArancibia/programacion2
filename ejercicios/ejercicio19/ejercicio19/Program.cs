using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades19;

namespace ejercicio19
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidadSumas;
            Sumador prueba1 = new Sumador(0);
           Sumador prueba2 = new Sumador(0);
            long contador;
            int cantidadSumas2;



            Console.WriteLine("prueba uno cantidad de sumas  {0}", prueba1.Sumar(10,10));
      
            Console.WriteLine("prueba2 uno cantidad de sumas  {0}", prueba2.Sumar("hola","10"));


            cantidadSumas =(int)prueba1;
            cantidadSumas2 = (int)prueba2;

            Console.WriteLine("Cantidad sumas: {0}", cantidadSumas);
            Console.WriteLine("Cantidad sumas 2: {0}", cantidadSumas2);

            contador = prueba1 + prueba2;

            Console.WriteLine("Contador: {0}", contador);

            if (prueba1 | prueba2)
            {
                Console.WriteLine("Poseen la misma cantidad de sumas");

            }
            else
            {
                Console.WriteLine("Los valores son diferentes");
            }

            Console.ReadKey();
        }
    }
}
