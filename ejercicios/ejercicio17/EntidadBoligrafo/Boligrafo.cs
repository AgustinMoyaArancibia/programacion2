using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadBoligrafo
{
    public class Boligrafo
    {
        private const short cantidadTintaMaxima = 100;

        ConsoleColor color;
        short tinta;

        public Boligrafo(ConsoleColor color , short tinta)
        {
            this.color = color;
            this.tinta = tinta;
        }

        public ConsoleColor GetColor()
        {
            return this.color;
        }

        public short GetTinta()
        {

            return this.tinta;
        }

        private void SetTinta(short tinta)
        {
            this.tinta = tinta;

            if (this.tinta < 0)
            {
                this.tinta = 0;
            }
            else if (this.tinta > cantidadTintaMaxima)
            {
                this.tinta = cantidadTintaMaxima;
            }
        }

        public void Recargar()
            {
                this.SetTinta(100);
            Console.WriteLine("recarga exitosa");
            }

        public bool Pintar(short gasto, out string dibujo) 
        {
            bool retorno = false;
            dibujo = "";
            int estadoTinta;

            estadoTinta =  this.tinta; // agrego tinta actual

            estadoTinta = estadoTinta - gasto; // resto el gasto a tinta

            if(estadoTinta > -1) //pregunto si hay tinta
            {
                this.SetTinta((short)estadoTinta); // gurado el cambio del estado de tinta
                for (int i = 0; i < gasto; i++)
                {
                    dibujo = dibujo + "*";
                }
                retorno = true;
            }

            return retorno;
        }

    }
}
