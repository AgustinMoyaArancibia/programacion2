using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadBoligrafo;

namespace ejercicio17
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            short gastoTinta;
            string dibujoAzul;
            string dibujoRojo;
            Boligrafo boligrafoAzul = new Boligrafo(ConsoleColor.Blue, 100); // creo objeto 
            Boligrafo boligrafoRojo = new Boligrafo(ConsoleColor.Red, 50);

            do
            {
                Console.WriteLine("\nMenu dibujo");
                Console.WriteLine("1.dibujar boligrafo azul");
                Console.WriteLine("2.dibujar boligrafo rojo");
                Console.WriteLine("3.regargar boligrafo azul");
                Console.WriteLine("4.recargar boligrafo rojo");
                Console.WriteLine("5.salir");
                int.TryParse(Console.ReadLine(), out opcion);

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("ingrese el gasto de tinta a usar");
                        short.TryParse(Console.ReadLine(), out gastoTinta);

                        if (boligrafoAzul.Pintar(gastoTinta, out dibujoAzul)) // si es verdadero
                        {
                            Console.ForegroundColor = boligrafoAzul.GetColor();// pinto las letras de color
                            Console.WriteLine($"Dibujo azul: {dibujoAzul}");
                            Console.ForegroundColor = ConsoleColor.White;// vuelvo las letras a blaco
                        }
                        else
                        {
                            Console.WriteLine("no hay mas tinta , recarge");
                        }
                        break;
                    case 2:
                        Console.WriteLine("ingrese el gasto de tinta a usar");
                        short.TryParse(Console.ReadLine(), out gastoTinta);

                        if (boligrafoRojo.Pintar(gastoTinta, out dibujoRojo))
                        {
                            Console.ForegroundColor = boligrafoRojo.GetColor();// pinto las letras de color
                            Console.WriteLine($"Dibujo rojo: {dibujoRojo}");
                            Console.ForegroundColor = ConsoleColor.White;// vuelvo las letras a blaco
                        }
                        else
                        {
                            Console.WriteLine("no hay mas tinta , recarge");
                        }
                        break;
                    case 3:
                        boligrafoAzul.Recargar(); 
                        break;
                    case 4:
                        boligrafoRojo.Recargar();
                        break;
                    case 5:
                        Console.WriteLine("usted salio");
                        break;
                }

                
                

            } while (opcion != 5);
            Console.ReadKey();
        }
    }
}
