using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Hacer un programa que pida por pantalla la fecha de nacimiento de una persona (día, mes y año) y
//calcule el número de días vividos por esa persona hasta la fecha actual (tomar la fecha del sistema
//con DateTime.Now).
//Nota: Utilizar estructuras selectivas.Tener en cuenta los años bisiestos.


namespace ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime fecha;
            DateTime fechaActual;

            fecha = new DateTime(1997,08, 16); // pedir fecha hardcodeada
            fechaActual = DateTime.Now.Date;
            Console.WriteLine("fecha: {0} ",fecha.ToString());// mostrar fecha
            Console.WriteLine("fecha actual: {0} ", fechaActual.ToString());// mostrar fecha actual
            //diasVividos = fechaActual.Subtract(fecha).Days;

            Console.WriteLine("los dias vividos hasta la actualidad: {0}", fechaActual.Subtract(fecha).Days);


            Console.ReadKey();




        }
    }
}
