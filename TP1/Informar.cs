using System;

namespace Metodologías.TP1
{
    public class Informar
    {
        public void infomar(Coleccionable c)
        {
            Console.WriteLine("Cantidad: "+c.cuantos());
            Console.WriteLine("Mínimo: "+c.minimo());
            Console.WriteLine("Máximo: "+c.maximo());
            Console.WriteLine("Ingrese número: ");
            Comparable temp = new Numero(int.Parse(Console.ReadLine()));
            if(c.contiene(temp))
            {
                Console.WriteLine("El elemento leído está en la colección");
            }
            else
            {
                Console.WriteLine("El elemento leído no está en la colección");
            }
        }
    }
}
