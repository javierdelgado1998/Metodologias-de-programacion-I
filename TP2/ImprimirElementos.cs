using System;
namespace Metodologías.TP2
{
    public class ImprimirElementos
    {
        public void imprimirElementos(Iterable c)
        {
            Iterador x = c.crearIterador();
            while(!x.fin())
            {
                Console.Write(x.actual() + " ");
                x.siguiente();
            }
        }
        public void imprimirElementos2(Iterable c,Alumno promedio, EstrategiaComparacion estrategia)
        {
            Iterador x = c.crearIterador();
            promedio.setEstrategia(estrategia);
            while(!x.fin())
            {
                Comparable actual = (Comparable) x.actual();
                if(actual.sosMayor(promedio))
                {
                    Console.Write(actual + " ");
                }
                x.siguiente();
            }
        }
    }
}