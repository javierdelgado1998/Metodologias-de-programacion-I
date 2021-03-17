using System;
namespace Metodologías.TP7
{
    public class LlenarInformar
    {
        public void llenar(Coleccionable c, int opcion)
        {
            for (int i = 0; i < 20; i++)
            {
                Comparable x = FabricaDeComparables.crearAleatorio(opcion);
                c.agregar(x);
            }
        }
        public void informar(Coleccionable c, int opcion)
        {
            Console.Write("\nCuantos: "+c.cuantos());
            Console.Write("\nMínimo: "+c.minimo());
            Console.Write("\nMáximo: "+c.maximo());
            Comparable x = FabricaDeComparables.crearPorTeclado(opcion);
            if(c.contiene(x))
            {
                Console.WriteLine("El elemento leído está en la colección.");
            }
            else
            {
                Console.WriteLine("El elemento leído no está en la colección.");
            }
        }
        public void imprimirElementos(Iterable c)
        {
            Iterador x = c.crearIterador();
            while(!x.fin())
            {
                Console.Write(x.actual() + " ");
                x.siguiente();
            }
        }
    }
}