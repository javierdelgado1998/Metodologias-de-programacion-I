using System;
namespace Metodologías.TP7
{
    public abstract class Manejador
    {
        protected Manejador siguiente;
        public Manejador(Manejador siguiente)
        {
            this.siguiente = siguiente;
        }
        virtual public string stringPorTeclado()
        {
            if(siguiente != null)
            {
                return siguiente.stringPorTeclado();
            }
            else
            {
                return null;
            }
        }
        virtual public int numeroPorTeclado()
        {
            if(siguiente != null)
            {
                return siguiente.numeroPorTeclado();
            }
            else
            {
                return -1;
            }
        }
        virtual public int numeroAleatorio(int max)
        {
            if(siguiente != null)
            {
                return siguiente.numeroAleatorio(max);
            }
            else
            {
                return -1;
            }
        }
        virtual public string stringAleatorio(int longitud)
        {
            if(siguiente != null)
            {
                return siguiente.stringAleatorio(longitud);
            }
            else
            {
                return null;
            }
        }
		virtual public string stringDesdeArchivo(int cant)
        {
            if(siguiente != null)
            {
                return siguiente.stringDesdeArchivo(cant);
            }
            else
            {
                return null;
            }
		}
		virtual public double numeroDesdeArchivo(double max)
        {
            if(siguiente != null)
            {
                return siguiente.numeroDesdeArchivo(max);
            }
            else
            {
                return -1;
            }
		}
    }
}