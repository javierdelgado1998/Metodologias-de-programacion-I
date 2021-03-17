using System;
using System.Collections.Generic;
namespace Metodologías.TP6
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
    public class LectorDeDatos
    {
        public int numeroPorTeclado()
        {
            Console.Write("\nNumero: ");
            return int.Parse(Console.ReadLine());
        }
        public string stringPorTeclado()
        {
            Console.Write("\nString: ");
            return Console.ReadLine();
        }
    }
}