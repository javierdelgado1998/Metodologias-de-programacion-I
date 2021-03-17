using System;
namespace Metodologías.TP1
{
    public class InformarPersona
    {
        public void informarPersona(Coleccionable c)
        {
            Console.WriteLine("Cantidad: "+c.cuantos());
            Console.WriteLine("Mínimo: "+c.minimo());
            Console.WriteLine("Máximo: "+c.maximo());
            Console.WriteLine("Ingrese número: ");
            int dni = int.Parse(Console.ReadLine());
            Comparable temp = new Persona(dni);
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