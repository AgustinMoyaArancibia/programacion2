using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int s;

            for (int i = 2; i <= 70000; i++)
            {
                b = 0;
                s = i / 2;

                for (int j = 1; j <= s ; j++)
                {
                    a = i % j;

                    if(a == 0) 
                    {
                        b = b + j;
                    }
                    
                }
                if (b == i)
                {
                    Console.WriteLine("el numero " + i + "es perfecto");
                } 
               

            }
            Console.ReadKey();
        }
        
    }
}
