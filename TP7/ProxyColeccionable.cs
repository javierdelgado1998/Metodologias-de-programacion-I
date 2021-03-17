using System;
namespace Metodologías.TP7
{
    public class ProxyCola : Coleccionable, IObservador
    {
        private Comparable minimoValor;
        private Comparable maximoValor;
        private Coleccionable colaReal = null;
        public int cuantos()
        {
            if(colaReal != null)
            {
                return colaReal.cuantos();
            }
            else
            {
                return 0;
            }
        }
        public bool contiene(Comparable comparable)
        {
            if(colaReal != null)
            {
                return colaReal.contiene(comparable);
            }
            else
            {
                return false;
            }
        }
        public Comparable minimo()
        {
            if(colaReal != null)
            {
                if(minimoValor == null)
                {
                    minimoValor = colaReal.minimo();
                }
                return minimoValor;
            }
            else
            {
                return null;
            }
        }
        public Comparable maximo()
        {
            if(colaReal != null)
            {
                if(maximoValor == null)
                {
                    maximoValor = colaReal.maximo();
                }
                return maximoValor;
            }
            else
            {
                return null;
            }
        }
        public void agregar(Comparable c)
        {
            if(colaReal == null)
            {
                colaReal = new Cola();
            }
            colaReal.agregar(c);
            minimoValor = null;
            maximoValor = null;
        }
        public void actualizar(IObservado o)
        {
            minimoValor = null;
            maximoValor = null;
        }
        public void ordenar()
        {
            if(colaReal != null)
            {
                colaReal.ordenar();
            }
        }
        public void setOrdenInicio(OrdenEnAula1 ordenEnAula1)
        {

        }
        public void setOrdenLlegaAlumno(OrdenEnAula2 ordenEnAula1)
        {

        }
        public void setOrdenAulaLlena(OrdenEnAula1 ordenEnAula1)
        {

        }

    }
}