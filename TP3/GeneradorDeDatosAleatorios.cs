using System;
using System.Collections.Generic;
namespace Metodologías.TP3
{
    public class GeneradorDeDatosAleatorios
    {
        private Random random;
        public GeneradorDeDatosAleatorios()
        {
            random = new Random();
        }
        public int numeroAleatorio(int max)
        {
            return random.Next(0,max);
        }
        public string stringAleatorio(int longitud)
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var stringC = new char[longitud];
            for (int i = 0; i < longitud; i++)
            {
                stringC[i] = chars[random.Next(chars.Length)];
            }
            var finalString = new string(stringC);
            return finalString;
        }
        public Random getRandom()
        {
            return random;
        }
    }
}