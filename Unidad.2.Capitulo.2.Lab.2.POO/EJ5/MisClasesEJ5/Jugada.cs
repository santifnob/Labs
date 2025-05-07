using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisClasesEJ5
{
    public class Jugada
    {
        private int intentos = 0;
        private int numero;
        private bool adivino = false;

        public Jugada(int maxNumero)
        {
            Random rnd = new Random(); 
            int numero = rnd.Next(maxNumero);

        }

        public int Intentos
        {
            get => intentos;
            set
            {
            }
        }

        public bool Adivino
        {
            get => adivino;
            set
            {
            }
        }

        public int Numero
        {
            get => default;
            set
            {
            }
        }

        public void Comparar(int aComparar)
        {
            if (numero == aComparar)
            {
                adivino = true;
                Console.WriteLine("Acerto!");

            }
            else
            {
                Console.WriteLine("No acertado");
            }


            intentos++;
        }
    }
}
