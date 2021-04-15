using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using conversores;
//Desarrollar una clase llamada Conversor, que posea dos métodos de clase (estáticos):
//string DecimalBinario(int). Convierte un número de entero a binario.
//int BinarioDecimal(string). Convierte un número binario a entero.

namespace ejercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 11;
            string numeroADecimal;
            string binario = "11";
            numeroADecimal = conversor.DecimalBinario(numero);

            Console.WriteLine(numeroADecimal);
            Console.WriteLine("numero decimal {0} ",conversor.BinarioDecimal(binario));

            Console.ReadKey();

        }
    }
}
