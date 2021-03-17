using System;
namespace Metodologías.TP3
{
    public class ImprimirElementos
    {
        public void imprimirMejores(Iterable c)
        {
            Iterador x = c.crearIterador();
            while(!x.fin())
            {
                Vendedor v = (Vendedor)x.actual();
                Console.Write(v.getNombre() + " " + v.getBonus() + " ");
                x.siguiente();
            }
        }
        public void agregarObservadores(Iterable c, IObservador o)
        {
            Iterador x = c.crearIterador();
            while(!x.fin())
            {
                Vendedor v = (Vendedor)x.actual();
                v.agregarObservador(o);
                x.siguiente();
            }
        }
        public void jornadaDeVentas(Iterable c)
        {
            GeneradorDeDatosAleatorios g = new GeneradorDeDatosAleatorios();
            Iterador x = c.crearIterador();
            for (int i = 0; i < 20; i++)
            {
                x.primero();
                while(!x.fin())
                {
                    Vendedor v = (Vendedor)x.actual();
                    float monto = (float)g.numeroAleatorio(10000);
                    v.venta(monto);
                    x.siguiente();
                }                      
            }
        }
    }
}