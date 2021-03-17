using System;
using System.Collections.Generic;
namespace Metodologías.TP7
{
    public class GeneradorDeDatosAleatorios : Manejador
    {
        static private GeneradorDeDatosAleatorios generador;
        private Random random;
        private GeneradorDeDatosAleatorios(Manejador siguiente):base(siguiente)
        {
            random = new Random();
        }
        static public GeneradorDeDatosAleatorios getInstance(Manejador siguiente)
        {
            if(generador == null)
            {
                generador = new GeneradorDeDatosAleatorios(siguiente);
            }
            return generador;
        }
        public override int numeroAleatorio(int max)
        {
            return random.Next(0,max);
        }
        public override string stringAleatorio(int longitud)
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
    }
    public class LectorDeDatos : Manejador
    {
        static private LectorDeDatos lector;
        private LectorDeDatos(Manejador siguiente):base(siguiente)
        {

        }
        static public LectorDeDatos getInstance(Manejador siguiente)
        {
            if(lector == null)
            {
                lector = new LectorDeDatos(siguiente);
            }
            return lector;
        }
        public override int numeroPorTeclado()
        {
            Console.Write("\nNumero: ");
            return int.Parse(Console.ReadLine());
        }
        public override string stringPorTeclado()
        {
            Console.Write("\nString: ");
            return Console.ReadLine();
        }
    }
}