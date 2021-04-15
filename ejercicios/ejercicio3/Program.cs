using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3
{

//    mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario
//por consola.
//nota: utilizar estructuras repetitivas, selectivas y la función módulo (%).
    class Program
    {
        static void Main(string[] args) 
        {
            int numero = 2; // empezamos desde el dos porque damos por echo que el numero 1 no es primo
            int divisible = 0;
            int numeroPedido;

            Console.WriteLine("ingrese numero ");
            numeroPedido = int.Parse(Console.ReadLine());
        while(numero <= numeroPedido) 
            {
                for (int i = 1; i <= numero; i++) 
                {
                    if(numero%i == 0) //se va dividiendo 
                    {
                        divisible++;
                    }
                    if(divisible > 2) 
                    {
                        break;
                    }
                }
                if(divisible ==2) 
                {
                    Console.WriteLine("los numeros primos son : {0}", numero);
                }
                divisible = 0;
                numero++; // sumamos unos al dar la vuelta
            }
            Console.ReadKey();
        }
    }
}
