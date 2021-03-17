using System;
namespace Metodologías.TP3
{
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