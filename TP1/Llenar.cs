
using System;
namespace Metodologías.TP1
{
    public class Llenar
    {
        public void llenar(Coleccionable c)
        {
            Random r = new Random();
            for (int i = 0; i < 20; i++)
            {
                Comparable  x = new Numero(r.Next(1,100));
                Console.Write(x+ " ");
                c.agregar(x);
            }
        }
    }
}