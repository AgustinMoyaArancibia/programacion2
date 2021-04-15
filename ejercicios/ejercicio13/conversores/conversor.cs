using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace conversores
{
    public class conversor
    {
        public static string DecimalBinario(int numero)

//            Cogemos el modulo de 2 de ese numero.
//Multiplicamos ese numero por 10 elevado al indice correspondiente.
//Lo sumamos al total.
//Dividimos el numero entre 10.
//Repetimos el proceso anterior hasta llegar a 0
        {

            string resultado = null;

            if(numero > 0) 
            {
                while (numero > 0)
                {

                    if (numero % 2 == 0)
                    {
                        resultado = "0" + resultado;
                    }
                    else
                    {
                        resultado = "1" + resultado;
                    }

                    numero = numero / 2;

                }
            }
            else 
            {
                resultado = "valor nulo";
            }

            

            return resultado;
        }

        public static int BinarioDecimal(string binario) 
        {


            double acumulador = 0;
            char[] array = binario.ToCharArray();
            Array.Reverse(array);

            if (EsBinario(binario))
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == '1')
                    {
                        acumulador += Math.Pow(2, i);
                    }

                }

            }


            return (int)acumulador;
        }


        private static bool EsBinario(string binario)
        {
            bool retorno = true;
            char[] array = binario.ToCharArray();

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != '0' && array[i] != '1')
                {
                    retorno = false;
                    break;
                }
            }

            return retorno;
        }
    }
}
